namespace Finite_State_Machine
{
    public interface IStateSwitcher
    {
        void Switch<TState>() where TState : IState;
    }
}
