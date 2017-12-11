using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// parent command class. To be inherited by any child command class
public abstract class Command {

    // called whenever the command is to be executed by the actor 
    public abstract void execute(Actor actor);
}
