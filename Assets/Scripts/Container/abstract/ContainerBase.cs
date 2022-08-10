using System;
using System.Collections.Generic;
using Container.Interfaces;

namespace Container.@abstract
{
    /// <summary>
    /// 容器接口的实现基类
    /// </summary>
    /// <author>Zyxxxxxi</author>
    /// <date>2022/08/10</date>
    public abstract class ContainerBase : IContainer
    {
        protected Dictionary<object, object> container;

        protected ContainerBase()
        {
            container = new Dictionary<object, object>();
        }

        protected ContainerBase(Dictionary<object, object> objects)
        {
            container = new Dictionary<object, object>(objects);
        }

        public abstract void AddObjects(Dictionary<object, object> objects);
        public abstract void AddObject(object key, object obj);
        public abstract object GetObject(object key);
        public abstract object GetObject(Type type);
    }
}