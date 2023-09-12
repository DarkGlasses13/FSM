namespace Finite_State_Machine
{
    public interface IState
    {
        void Enter();
        void Update();
        void Exit();
    }
}
