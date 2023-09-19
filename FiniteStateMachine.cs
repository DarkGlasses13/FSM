using System.Collections.Generic;
using System.Linq;

namespace Finite_State_Machine
{
    public class FiniteStateMachine : IFiniteStateMachine
    {
        private readonly List<IState> _states = new();

        public IState CurrentState { get; private set; }

        public void AddState(IState state)
        {
            if (_states.Contains(state))
                return;

            _states.Add(state);
        }

        public void AddStates(IEnumerable<IState> states)
        {
            foreach (IState state in states)
            {
                AddState(state);
            }
        }

        public void Switch<TState>() where TState : IState
        {
            IState previousState = CurrentState;
            CurrentState = null;
            previousState?.Exit();
            IState nextState = _states.SingleOrDefault(state => state is TState);
            nextState?.Enter();
            CurrentState = nextState;
        }

        public void RemoveState(IState state) => _states.Remove(state);

        public void Clear()
        {
            CurrentState = null;
            _states.Clear();
        }
    }
}
