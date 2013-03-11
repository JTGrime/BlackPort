using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Generics.Infrastrcture.API;

namespace Generics.Infrastrcture.Behavioural
{
    public sealed class Singleton<T> : ISingleton<T>
    where T : new()
    {
        private T   _instance;
        static int  _instanceCount;

        public T Instance
        {
            get
            {
                _instance = (_instanceCount >= 1) ? _instance : new T();
                return _instance;
            }
            private set
            {
                if ((_instanceCount <= 0) &&
                    (!_instance.Equals(value)))
                {
                    _instance = value;
                }
            }
        }

        public Singleton()
        {
            _instance = new T();
            _instanceCount++;
        }
    }
}