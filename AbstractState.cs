namespace FSM
{
    public abstract class AbstractState
    {
        protected StateMachine stateMechine;

        public AbstractState(StateMachine stateMachine)
        {
            this.stateMechine = stateMachine;
        }
        public virtual void Enter()
        {

        }

        public virtual void HandleInput()
        {

        }

        public virtual void PhysicsUpdate()
        {

        }

        public virtual void LogicUpdate()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Exit()
        {

        }
    }
}