using System.Collections.Generic;
using Container.Structs;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace Container.core
{
    /// <summary>
    /// 容器配置
    /// </summary>
    /// <author>Zyxxxxxi</author>
    /// <date>2022/08/10</date>
    [CreateAssetMenu(fileName = "ContainerConfig", menuName = "Container/ObjectConfiguration", order = 0)]
    public class ObjectConfiguration : ScriptableObject
    {
        [Tooltip("配置名")]
        public new string name;

        [Tooltip("游戏对象组件")]
        public List<ObjectComponent> objectComponents;

        [Tooltip("普通组件")]
        public List<OrdinaryComponent> ordinaryComponents;
    }
}