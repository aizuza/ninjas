using System;

namespace Ninjas
{
    class Movement
    {
        // ?
        public float speed;

        // teclas
        
        public float crouchSpeed;
        public float walkSpeed;
        public float runSpeed;

        // - power up
        // - debuff
        // - run
        // - crouch

        public void Move()
        {

        }

        public void Run()
        {
            this.speed = this.runSpeed;
        }

        public void StopRunning()
        {
            this.speed = this.walkSpeed;
        }
    }
}