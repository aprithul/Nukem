using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommandGenerator: Pausable {

    protected bool is_paused;
    protected EmptyCommand empty_command = new EmptyCommand();
    public abstract Command get_next_command();

    public override void Pause(bool value)
    {
        is_paused = value;
    }
}
