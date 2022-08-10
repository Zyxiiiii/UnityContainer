using System;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace Container.exception
{
    /// <summary>
    /// 键已定义异常
    /// </summary>
    /// <author>Zyxxxxxi</author>
    /// <date>2022/08/10</date>
    public class KeyWasDefinedException : Exception
    {
        public KeyWasDefinedException()
        {
        }

        protected KeyWasDefinedException([NotNull] SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public KeyWasDefinedException(string message) : base(message)
        {
        }

        public KeyWasDefinedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}