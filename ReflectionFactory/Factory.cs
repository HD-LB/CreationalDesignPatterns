using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionFactory
{
    public class Factory
    {
        private static IDictionary<string, Type> regesteredTypes = new Dictionary<string, Type>();

        public static void Regester<T>(string typeId)
        {
            var type = typeof(T);
            if (type.IsAbstract || type.IsInterface)
            {
                throw new ArgumentException("Cannot create abstract type " + type.Name);
            }

            regesteredTypes.Add(typeId, type);
        }

        public static T Create<T>(string id, params object[] parameters)
        {
            Type typeToCreate;
            if (!regesteredTypes.TryGetValue(id, out typeToCreate))
            {
                throw new NotSupportedException("Type with id [" + id + "] is not regestered");
            }

            return (T)Activator.CreateInstance(typeToCreate, parameters);
        }
    }
}
