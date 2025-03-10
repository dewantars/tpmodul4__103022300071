using System;

namespace tpmodul4__103022300071
{
    public class DoorMachine
    {
        public enum State
        {
            TERKUNCI,
            TERBUKA
        }

        public enum Trigger
        {
            LOCK,
            UNLOCK
        }

        private State currentState;

        public DoorMachine()
        {
            currentState = State.TERKUNCI;
            Console.WriteLine("Pintu terkunci");
        }

        public void ActivateTrigger(Trigger trigger)
        {
            switch (currentState)
            {
                case State.TERKUNCI:
                    if (trigger == Trigger.UNLOCK)
                    {
                        currentState = State.TERBUKA;
                        Console.WriteLine("Pintu tidak terkunci");
                    }
                    break;

                case State.TERBUKA:
                    if (trigger == Trigger.LOCK)
                    {
                        currentState = State.TERKUNCI;
                        Console.WriteLine("Pintu terkunci");
                    }
                    break;
            }
        }
    }

}
