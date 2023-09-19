using System.Collections.Generic;

namespace Finite_State_Machine
{
    public interface IFiniteStateMachine : IStateSwitcher
    {
        IState CurrentState { get; }

        void AddState(IState state);
        void AddStates(IEnumerable<IState> states);
        void RemoveState(IState state); 
        void RemoveState(IState state);
        void Clear()
    }
}
