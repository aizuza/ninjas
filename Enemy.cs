using System;
using System.Reflection;

namespace Ninjas
{
    class Enemy
    {
        // Qué tiene
        // (Igual que el Player)
        public Health health;

        // Qué acciones realiza
        // (Igual que el Player)

        public Enemy()
        {
            this.health = new Health(40, 40, 40);
        }






        

        // Unity-like method (requires [using System.Reflection;])
        public T GetComponent<T>()
        {
            FieldInfo[] fields = this.GetType().GetFields();
            foreach (FieldInfo field in fields)
            {
                if (field.FieldType == typeof(T))
                {
                    return (T) field.GetValue(this);
                }
            }
            return default(T);
        }
    }
}