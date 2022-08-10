using System.Collections.Generic;
using Container.core;
using UnityEngine;

namespace Container
{
    /// <summary>
    /// 容器驱动器
    /// </summary>
    /// <author>Zyxxxxxi</author>
    /// <date>2022/08/10</date>
    public class Driver : MonoBehaviour
    {
        [SerializeField] private List<ObjectConfiguration> objectConfigurations;
    }
}