using System.Collections.Generic;
using Container.Interfaces;

namespace Container.core
{
    public class ContainerStorage
    {
        private static Dictionary<string, IContainer> _containers;

        public static IContainer GetContainer(string name)
        {
            if (!_containers.ContainsKey(name))
            {
                throw new KeyNotFoundException($"不存在名为{name}的容器");
            }

            return _containers[name];
        }
    }
}