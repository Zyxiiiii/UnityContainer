using System;
using System.Collections.Generic;
using Container.@abstract;
using Container.exception;

namespace Container.core
{
    /// <summary>
    /// 默认的容器实现类
    /// </summary>
    /// <author>Zyxxxxxi</author>
    /// <date>2022/08/10</date>
    public class DefaultContainerImpl : ContainerBase
    {
        public override void AddObjects(Dictionary<object, object> objects)
        {
            foreach (var (key, value) in objects)
            {
                AddObject(key, value);
            }
        }

        public override void AddObject(object key, object obj)
        {
            if (container.ContainsKey(key))
            {
                throw new KeyWasDefinedException($"容器中已存在键为 {key} 的对象，请指定其他键");
            }

            container.Add(key, obj);
        }

        public override object GetObject(object key)
        {
            if (!container.ContainsKey(key))
            {
                throw new KeyNotFoundException($"容器中不存在键为 {key} 的对象，请指定其他键");
            }

            return container[key];
        }

        public override object GetObject(Type type)
        {
            object rs = null;
            foreach (var containerValue in container.Values)
            {
                if (containerValue.GetType() == type)
                {
                    if (rs != null)
                    {
                        throw new TypeRepetitionException($"容器内存在重复的类型 {type} ，请指定key来获取对应的对象");
                    }

                    rs = containerValue;
                }
            }

            if (rs == null)
            {
                foreach (var containerValue in container.Values)
                {
                    if (containerValue.GetType().IsSubclassOf(type))
                    {
                        if (rs != null)
                        {
                            throw new TypeRepetitionException($"容器内存在重复的类型 {type} ，请指定key来获取对应的对象");
                        }

                        rs = containerValue;
                    }
                }
            }

            return rs;
        }
    }
}