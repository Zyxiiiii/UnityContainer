using System;

namespace Container.attribute
{
    /// <summary>
    /// 标注在一个类上使得其成为一个容器组件
    /// </summary>
    /// <author>Zyxxxxxi</author>
    /// <date>2022/08/10</date>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property |
                    AttributeTargets.Method)]
    public class Component : Attribute
    {
        public Component()
        {
        }

        public Component(string name)
        {
            this.name = name;
        }

        public string name { get; }
    }
}