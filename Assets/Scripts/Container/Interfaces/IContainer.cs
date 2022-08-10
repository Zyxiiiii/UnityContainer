using System;
using System.Collections.Generic;

namespace Container.Interfaces
{
    /// <summary>
    /// 容器接口
    /// </summary>
    /// <author>Zyxxxxxi</author>
    /// <date>2022/08/10</date>
    public interface IContainer
    {
        /// <summary>
        /// 将对象添加到容器中
        /// </summary>
        /// <param name="obj">要添加的目标对象</param>
        void AddObject(object obj) => AddObject(obj.GetType().Name, obj);

        /// <summary>
        /// 将对象集添加到容器中
        /// </summary>
        /// <param name="dictionary">对象集合</param>
        void AddObjects(Dictionary<object, object> dictionary);

        /// <summary>
        /// 将对象添加到容器中
        /// </summary>
        /// <param name="key">对象在容器中的key</param>
        /// <param name="obj">目标对象</param>
        void AddObject(object key, object obj);

        /// <summary>
        /// 从容器中获取对象
        /// </summary>
        /// <param name="key">对象在容器中的key</param>
        /// <returns>目标对象</returns>
        object GetObject(object key);

        /// <summary>
        /// 从容器中获取对象
        /// </summary>
        /// <param name="type">对象的类型</param>
        /// <returns>目标对象</returns>
        object GetObject(Type type);

        /// <summary>
        /// 从容器中获取对象
        /// </summary>
        /// <typeparam name="T">对象的类型</typeparam>
        /// <returns>目标对象</returns>
        T GetObject<T>() => (T)GetObject(typeof(T));
    }
}