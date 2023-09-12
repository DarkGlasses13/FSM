namespace Finite_State_Machine
{
    public abstract class State : IState
    {
        protected readonly IStateSwitcher _switcher;

        protected State(IStateSwitcher switcher)
        {
            _switcher = switcher;
        }

        public abstract void Enter();
        public abstract void Exit();
        public abstract void Update();
    }
}
