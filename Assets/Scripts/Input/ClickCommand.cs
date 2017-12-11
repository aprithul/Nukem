using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// command for selecting a selectable_object
public class ClickDownCommand : Command
{
    private Vector2 click_position;

    public ClickDownCommand(Vector2 click_position)
    {
        this.click_position = click_position;
    }

    // make the actor select the selectable_object
    public override void execute( Actor actor)
    {
        if (actor.actor_collider_2d.bounds.Contains(click_position))
            actor.click();
    }
}
