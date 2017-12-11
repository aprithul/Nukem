using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State {
    protected StateManager state_manager;
    public State(StateManager state_manager)
    {
        this.state_manager = state_manager;
    }
    public abstract void update();
    protected abstract void to_next_state();

}
