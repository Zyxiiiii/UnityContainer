using System;

namespace Container.Structs
{
    /// <summary>
    /// 普通容器组件
    /// </summary>
    /// <author>Zyxxxxxi</author>
    /// <date>2022/08/10</date>
    [Serializable]
    public struct OrdinaryComponent
    {
        /// <summary>
        /// 指定全限定名，创建对象
        /// </summary>
        public string typeFullName;
    }
}