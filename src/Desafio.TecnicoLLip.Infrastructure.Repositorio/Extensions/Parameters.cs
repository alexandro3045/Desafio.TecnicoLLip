using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Extensions
{
    public static class Parameters
    {
        public static bool TryToInt32(object value, out int result)
        {
            if (value == null)
            {
                result = 0;

                return false;
            }
            var typeConverter = System.ComponentModel.TypeDescriptor.GetConverter(value);

            if (typeConverter != null && typeConverter.CanConvertTo(typeof(int)))
            {
                var convertTo = typeConverter.ConvertTo(value, typeof(int));

                if (convertTo != null)
                {
                    result = (int)convertTo;

                    return true;
                }
            }

            return int.TryParse(value.ToString(), out result);
        }

        public static object GetDBNullOrValue<T>(this T val)
        {
            bool isDbNull = true;
            Type t = typeof(T);

            if (Nullable.GetUnderlyingType(t) != null)
                isDbNull = EqualityComparer<T>.Default.Equals(default, val);
            else if (t.IsValueType)
                isDbNull = false;
            else
                isDbNull = val == null;

            return isDbNull ? DBNull.Value : (object)val;
        }

        public static object ConvertTo<T>(this object val)
        {
            if (val == DBNull.Value || val == null) return val;

            bool isDbNull = true;
            Type t = typeof(T);

            if (t != null)
            {
                var s = val.ToString();
                if (t == typeof(char))
                    return Convert.ToChar(s.First());
                if (t == typeof(int))
                    return Convert.ToInt32(s);
                if (t == typeof(Int64))
                    return Convert.ToInt64(s);
                if (t == typeof(string))
                    return Convert.ToString(s);
                if (t == typeof(Double))
                    return Convert.ToDouble(s);
                if (t == typeof(byte))
                    return Convert.ToByte(s);
            }
            else if (t.IsValueType)
                isDbNull = false;
            else
                isDbNull = val == null;

            return !isDbNull ? val : DBNull.Value;
        }
               

        public static string ExpressionValue<T>(this Expression<Func<T, bool>> expression)
        {
            return Expression.Lambda(((BinaryExpression)expression.Body).Right).Compile().DynamicInvoke() as string;
        }

        public static bool TryCast<T>(this object obj, out T result) where T : struct
        {
            if (obj == null)
            {
                result = default;
                return false;
            }

            if (obj is T)
            {
                result = (T)obj;
                return true;
            }

            result = default;

            return false;
        }
    }

    public class ExpressionEqualityComparer : IEqualityComparer<Expression>
    {
        public bool Equals(Expression x, Expression y)
        {
            return EqualsRecursive(x, y);
        }

        private bool EqualsRecursive(Expression x, Expression y)
        {
            if (x == null || y == null) return false;

            if (object.ReferenceEquals(x, y))
                return true;

            if (x.GetType() != y.GetType() ||
                x.Type != y.Type ||
                x.NodeType != y.NodeType)
            {
                return false;
            }


            if (x is LambdaExpression lambdaExpressionX && y is LambdaExpression lambdaExpressionY)
            {
                return AreAllArgumentsEqual(lambdaExpressionX.Parameters, lambdaExpressionY.Parameters) &&
                    Equals(lambdaExpressionX.Body, lambdaExpressionY.Body);
            }


            if (x is BinaryExpression binaryExpressionX && y is BinaryExpression binaryExpressionY)
            {
                return binaryExpressionX.Method == binaryExpressionY.Method &&
                    Equals(binaryExpressionX.Left, binaryExpressionY.Left) &&
                    Equals(binaryExpressionX.Right, binaryExpressionY.Right);
            }


            if (x is UnaryExpression unaryExpressionX && y is UnaryExpression unaryExpressionY)
            {
                return unaryExpressionX.Method == unaryExpressionY.Method &&
                    Equals(unaryExpressionX.Operand, unaryExpressionY.Operand);
            }


            if (x is MethodCallExpression methodCallExpressionX && y is MethodCallExpression methodCallExpressionY)
            {
                return AreAllArgumentsEqual(methodCallExpressionX.Arguments, methodCallExpressionY.Arguments) &&
                    methodCallExpressionX.Method == methodCallExpressionY.Method &&
                    Equals(methodCallExpressionX.Object, methodCallExpressionY.Object);
            }

            if (x is ConditionalExpression conditionalExpressionX && y is ConditionalExpression conditionalExpressionY)
            {
                return Equals(conditionalExpressionX.Test, conditionalExpressionY.Test) &&
                    Equals(conditionalExpressionX.IfTrue, conditionalExpressionY.IfTrue) &&
                    Equals(conditionalExpressionX.IfFalse, conditionalExpressionY.IfFalse);
            }

            if (x is InvocationExpression invocationExpressionX && y is InvocationExpression invocationExpressionY)
            {
                return AreAllArgumentsEqual(invocationExpressionX.Arguments, invocationExpressionY.Arguments) &&
                    Equals(invocationExpressionX.Expression, invocationExpressionY.Expression);
            }

            if (x is MemberExpression memberExpressionX && y is MemberExpression memberExpressionY)
            {
                return memberExpressionX.Member == memberExpressionY.Member &&
                    Equals(memberExpressionX.Expression, memberExpressionY.Expression);
            }

            if (x is ConstantExpression constantExpressionX && y is ConstantExpression constantExpressionY)
            {
                return constantExpressionX.Value.Equals(constantExpressionY.Value);
            }

            if (x is ParameterExpression parameterExpressionX && y is ParameterExpression parameterExpressionY)
            {
                return parameterExpressionX.Name == parameterExpressionY.Name;
            }

            if (x is NewExpression newExpressionX && y is NewExpression newExpressionY)
            {
                return AreAllArgumentsEqual(newExpressionX.Arguments, newExpressionY.Arguments) &&
                    newExpressionX.Constructor == newExpressionY.Constructor;
            }

            return false;
        }

        private bool AreAllArgumentsEqual<T>(IEnumerable<T> xArguments, IEnumerable<T> yArguments)
            where T : Expression
        {
            var argumentEnumeratorX = xArguments.GetEnumerator();
            var argumentEnumeratorY = yArguments.GetEnumerator();

            bool haveNotEnumeratedAllOfX = argumentEnumeratorX.MoveNext();
            bool haveNotEnumeratedAllOfY = argumentEnumeratorY.MoveNext();

            bool areAllArgumentsEqual = true;

            while (haveNotEnumeratedAllOfX && haveNotEnumeratedAllOfY && areAllArgumentsEqual)
            {
                areAllArgumentsEqual = Equals(argumentEnumeratorX.Current, argumentEnumeratorY.Current);
                haveNotEnumeratedAllOfX = argumentEnumeratorX.MoveNext();
                haveNotEnumeratedAllOfY = argumentEnumeratorY.MoveNext();
            }

            if (haveNotEnumeratedAllOfX || haveNotEnumeratedAllOfY)
            {
                return false;
            }

            return areAllArgumentsEqual;
        }

        public int GetHashCode(Expression obj)
        {
            if (obj is LambdaExpression lambdaExpressionX)
            {
                return XorHashCodes(lambdaExpressionX.Parameters) ^
                    GetHashCode(lambdaExpressionX.Body);
            }


            if (obj is BinaryExpression binaryExpressionX)
            {
                int methodHashCode = binaryExpressionX.Method != null ? binaryExpressionX.Method.GetHashCode() : binaryExpressionX.NodeType.GetHashCode();

                return methodHashCode ^
                    GetHashCode(binaryExpressionX.Left) ^
                    GetHashCode(binaryExpressionX.Right);
            }

            if (obj is UnaryExpression unaryExpressionX)
            {
                int methodHashCode = unaryExpressionX.Method != null ? unaryExpressionX.Method.GetHashCode() : unaryExpressionX.NodeType.GetHashCode();

                return methodHashCode ^
                    GetHashCode(unaryExpressionX.Operand);
            }


            if (obj is MethodCallExpression methodCallExpressionX)
            {
                return XorHashCodes(methodCallExpressionX.Arguments) ^
                    methodCallExpressionX.Method.GetHashCode() ^
                    GetHashCode(methodCallExpressionX.Object);
            }

            if (obj is ConditionalExpression conditionalExpressionX)
            {
                return
                    GetHashCode(conditionalExpressionX.Test) ^
                    GetHashCode(conditionalExpressionX.IfTrue) ^
                    GetHashCode(conditionalExpressionX.IfFalse);
            }


            if (obj is InvocationExpression invocationExpressionX)
            {
                return
                    XorHashCodes(invocationExpressionX.Arguments) ^
                    GetHashCode(invocationExpressionX.Expression);
            }

            if (obj is MemberExpression memberExpressionX)
            {
                return
                    memberExpressionX.Member.GetHashCode() ^
                    GetHashCode(memberExpressionX.Expression);
            }

            if (obj is ConstantExpression constantExpressionX)
            {
                int valueHash = constantExpressionX.Value != null ? constantExpressionX.Value.GetHashCode() : constantExpressionX.GetHashCode();
                return valueHash;
            }

            if (obj is NewExpression newExpressionX)
            {

                return
                    XorHashCodes(newExpressionX.Arguments) ^
                    newExpressionX.Constructor.GetHashCode();
            }

            return 0;
        }

        private int XorHashCodes<T>(IEnumerable<T> expressions)
            where T : Expression
        {
            int accumulatedHashCode = 0;

            foreach (var expression in expressions)
            {
                accumulatedHashCode ^= GetHashCode(expression);
            }

            return accumulatedHashCode;
        }
    }
}
