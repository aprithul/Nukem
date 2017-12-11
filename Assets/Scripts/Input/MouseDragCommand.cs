using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragCommand : Command
{
    private Vector2 mouse_position;

    public MouseDragCommand(Vector2 mouse_position)
    {
        this.mouse_position = mouse_position;
    }

    public override void execute(Actor actor)
    {
        if (actor.actor_collider_2d.bounds.Contains(mouse_position))
        {
            actor.move(mouse_position);
        }
            
    }
}
