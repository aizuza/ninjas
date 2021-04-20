using System;

namespace Ninjas
{
    // Que tiene -> Atributos (Programación orientada a objetos)
    // - colisión (*)
    // - vida / health
    // - :(

    // Que hace -> Métodos (Programación orientada a objetos)
    // > acciones / verbos
    // - movimiento -> Moverse() / Move()
    // - ataque -> Atacar() / Attack()
    class Player
    {
        // Atributos
        public Health health;

        public Movement movement;

        public int attackDamage = 30;

        public Player()
        {
            this.health = new Health(100, 100, 100);
        }

        // Métodos
        public void Move()
        {

        }

        /// <summary>
        /// Attacks a target
        /// </summary>
        /// <returns>true if attack was a success</returns>
        public bool Attack(Health target)
        {
            if (target == null)
            {
                return false;
            }

            // if (target.health.health == 0)
            // {
            //     return false;
            // }

            if (target.IsDead())
            {
                return false;
            }

            target.TakeDamage(this.attackDamage);
            
            return true;
        }
    }
}