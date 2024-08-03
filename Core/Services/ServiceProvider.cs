using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace CounterSalary.Core.Services
{
    public class ServiceProvider : ICollection<ServiceBase>, IEnumerable<ServiceBase>
    {
        private List<ServiceBase> _services;
        public int Count => throw new System.NotImplementedException();

        public bool IsReadOnly => throw new System.NotImplementedException();

        public ServiceProvider(IEnumerable<ServiceBase> services)
        {
            _services = services.ToList();

            foreach (var service in _services)
            {
                service.Initialize();
            }
        }

        public void Add(ServiceBase item)
        {
            _services.Add(item);
            item.Initialize();
        }

        public void Clear()
        {
            _services.Clear();
        }

        public bool Contains(ServiceBase item)
        {
            return _services.Contains(item);
        }

        public void CopyTo(ServiceBase[] array, int arrayIndex)
        {
            _services.CopyTo(array, arrayIndex);
        }

        public IEnumerator<ServiceBase> GetEnumerator()
        {
            return _services.GetEnumerator();
        }

        public bool Remove(ServiceBase item)
        {
            return _services.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return _services.GetEnumerator();
        }
    }
}
