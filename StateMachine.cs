using System;

namespace FSM
{
    public abstract class StateMachine
    {

        public AbstractState CurrentState;

        public virtual void Initialize(AbstractState initState)
        {
            if (initState != null)
            {
                CurrentState = initState;
                CurrentState.Enter();
            }
            else
            {
                throw new NullReferenceException("Â FSM Initizize " + this.ToString() + " sended null state");
            }
        }

        public virtual void ChangeState(AbstractState nextState)
        {
            if (nextState != null)
            {
                CurrentState.Exit();
                CurrentState = nextState;
                CurrentState.Enter();
            }
            else
            {
                throw new NullReferenceException("Â ChangeState " + this.ToString() + " sended null state");
            }
        }
    }
}