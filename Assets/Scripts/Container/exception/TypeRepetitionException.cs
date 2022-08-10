using System;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace Container.exception
{
    /// <summary>
    /// 类型重复异常
    /// </summary>
    /// <author>Zyxxxxxi</author>
    /// <date>2022/08/10</date>
    public class TypeRepetitionException : Exception
    {
        public TypeRepetitionException()
        {
        }

        protected TypeRepetitionException([NotNull] SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public TypeRepetitionException(string message) : base(message)
        {
        }

        public TypeRepetitionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}