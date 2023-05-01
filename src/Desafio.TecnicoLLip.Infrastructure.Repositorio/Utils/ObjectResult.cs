#region Includes
using System;
using System.Text;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.Data.Utils
{  
    public sealed class ObjectResult<TEntity>  where TEntity : Domain.Models.Base.Base
    {
        #region Properties
        public int ErrorCod { get; set; }
        public string Message => Messages?.ToString();
        public int Result { get; set; }
        public TEntity Entity { get; set; }
        public StringBuilder Messages { get; set; }
        public Exception Exception { get; set; }
        private string Json { get; set; }
        public bool IsError => ErrorCod > 0 || !Equals(Exception, null);
        #endregion

        #region Constructor
        private ObjectResult()
        {
            ErrorCod = 0;
            Messages = new StringBuilder();
            Result = 0;
            Exception = null;
        }
        #endregion

        #region Singleton
        private static ObjectResult<TEntity> _instance;
        public static ObjectResult<TEntity> Instance
        {
            get { return _instance ?? (_instance = new ObjectResult<TEntity>()); }
        }
        #endregion

        #region Methods
        public void Destroy()
        {
            _instance = null;
            Messages = default;
            ErrorCod = default;
            Json = default;
        } 
        public void Append(string message, int errorCode = default)
        {
            Messages.AppendLine(string.Join("\t", message));
            ErrorCod = errorCode;
        }
        public void Append(string message, Exception ex)
        {
            Append(message, ex.HResult);
            Exception = ex;
        }
        public void Append(string message, Exception ex, int errorCode)
        {
            Append(message, errorCode);
            Exception = ex;
        }
        public void Append(string message, TEntity entity)
        {
            Entity = entity;
            Append(message);
        }
        public void Append(Exception ex)
        {
            Exception = ex;
        }
        public void Append(int errorCode)
        {
            ErrorCod = errorCode;
        }
        public void Append(TEntity entity)
        {
            Entity = entity;
        }
        public void Transform(object result)
        {
            ErrorCod = result.Property<int>("ErrorCod");
            Json = result.Property<TEntity>("Entity").ToJSON();
            Messages = result.Property<StringBuilder>("Messages");
            Exception = result.Property<Exception>("Exception");
        }
        
        #endregion
    }
}
