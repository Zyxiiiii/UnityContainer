using System;
using UnityEngine;

namespace Container.Structs
{
    /// <summary>
    /// 将场景中的对象添加到容器中
    /// </summary>
    /// <author>Zyxxxxxi</author>
    /// <date>2022/08/10</date>
    [Serializable]
    public struct ObjectComponent
    {
        public string name;

        public GameObject gameObject;
    }
}