using FluentValidation;
using FluentValidation.Validators;
using System;

namespace Desafio.TecnicoLLip.Domain.Validations
{
    public static  class CustomValidators
    {
        private static  IRuleBuilderOptions<T, int?> GreaterThanZero<T>(this IRuleBuilder<T, int?> ruleBuilder)
        {
            return ruleBuilder
                .GreaterThan(0);
        }

        private static  IRuleBuilderOptions<T, int> GreaterThanZero<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            return ruleBuilder
                .GreaterThan(0);
        }

        public static  IRuleBuilderOptions<T, string> Greater<T>(this IRuleBuilder<T, string> ruleBuilder, int tam)
        {
            return ruleBuilder
                .MaximumLength(tam)
                .WithMessage(String.Concat("{PropertyName} must be at least 1 but no more than ", tam, " characters long."));
        }

        public static  IRuleBuilderOptions<T, short> Greater<T>(this IRuleBuilder<T, short> ruleBuilder, int tam)
        {
            IRuleBuilderOptions<T, short> t = null;
            try
            {
                t = ruleBuilder
                    .Greater(tam)
                    .WithMessage(String.Concat("{PropertyName} must be at least 1 but no more than ", tam, " characters long."));
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }

            return t;
        }

        public static  IRuleBuilderOptions<T, char> GreaterThanZero<T>(this IRuleBuilder<T, char> ruleBuilder)
        {
            return ruleBuilder
                .GreaterThan((char)0)
                .WithMessage("Id unique identifier must be greater to 0");
        }

        public static  IRuleBuilderOptions<T, short> GreaterThanZero<T>(this IRuleBuilder<T, short> ruleBuilder)
        {
            return ruleBuilder
                .GreaterThan((short)0)
                .WithMessage("Id unique identifier must be greater to 0");
        }


        public static  IRuleBuilderOptions<T, short?> GreaterThanZero<T>(this IRuleBuilder<T, short?> ruleBuilder)
        {
            return ruleBuilder
                .GreaterThan((short)0)
                .WithMessage("Id unique identifier must be greater to 0");
        }
        
        public static  IRuleBuilderOptions<T, int?> IsRequired<T>(this IRuleBuilder<T, int?> ruleBuilder)
        {
            return ruleBuilder
              .GreaterThanZero()
              .WithMessage("{PropertyName} must not be null or empty or zero");
        }

        public static  IRuleBuilderOptions<T, Int16> IsRequired<T>(this IRuleBuilder<T, Int16> ruleBuilder)
        {
            return ruleBuilder
              .GreaterThanZero()
              .WithMessage("{PropertyName} must not be null or empty or zero");
        }

        public static  IRuleBuilderOptions<T, Int32> IsRequired<T>(this IRuleBuilder<T, Int32> ruleBuilder)
        {
            return ruleBuilder
              .GreaterThanZero()
              .WithMessage("{PropertyName} must not be null or empty or zero");
        }

        public static  IRuleBuilderOptions<T, object> IsRequired<T>(this IRuleBuilder<T, object> ruleBuilder)
        {
            return ruleBuilder
               .NotNull()
                .NotEmpty()
              .WithMessage("{PropertyName} must not be null or empty or zero");
        }

        public static  IRuleBuilderOptions<T, string> NotNullNotEmpty<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, short> NotNullNotEmpty<T>(this IRuleBuilder<T, short> ruleBuilder)
        {
            IRuleBuilderOptions<T, short> t = null;
            try
            {
                t =  ruleBuilder
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("{PropertyName} must not be null or empty");
            }
            catch(Exception d)
            {
                Console.Write(d.Message);
            }

            return t;
        }

        public static  IRuleBuilderOptions<T, char> NotNullNotEmpty<T>(this IRuleBuilder<T, char> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, char?> NotNullNotEmpty<T>(this IRuleBuilder<T, char?> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, DateTime?> NotNullNotEmpty<T>(this IRuleBuilder<T, DateTime?> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, DateTime> NotNullNotEmpty<T>(this IRuleBuilder<T, DateTime> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, short?> NotNullNotEmpty<T>(this IRuleBuilder<T, short?> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, byte> NotNullNotEmpty<T>(this IRuleBuilder<T, byte> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, byte[]> NotNullNotEmpty<T>(this IRuleBuilder<T, byte[]> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, byte?> NotNullNotEmpty<T>(this IRuleBuilder<T, byte?> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, int?> NotNullNotEmpty<T>(this IRuleBuilder<T, int?> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, int> NotNullNotEmpty<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, bool> BoolNotNullNotEmpty<T>(this IRuleBuilder<T, bool> ruleBuilder)
        {
            return ruleBuilder
                .Must(x => !x || x.GetHashCode() == 1)
                .WithMessage("{PropertyName} must not be null or empty");
        }

        public static  IRuleBuilderOptions<T, TProperty> IsValidDomain<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new IsInEnumValidator<TProperty>());
        }
    }

    public class IsInEnumValidator<T> : PropertyValidator
    {
        public IsInEnumValidator() : base("Property {PropertyName} it not a valid value.") { }
        protected override bool IsValid(PropertyValidatorContext context)
        {
            if (!typeof(T).IsEnum) return false;
            return Enum.IsDefined(typeof(T), context.PropertyValue);
        }
    }
}
