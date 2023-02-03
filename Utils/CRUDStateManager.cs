using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.Utils
{
    public partial class CRUDStateManager
    {
        public State state;
        public enum State
        {
            Insert, Update, Delete, Default
        }

        public CRUDStateManager(State _state = State.Default)
        {
            state = _state;
        }
        public void SetState(State _state)
        {
            state = _state;
        }
    }
    
}
