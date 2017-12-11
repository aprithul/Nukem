using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Actor parent class ( Player actor or AI actor )
[RequireComponent(typeof(Collider2D))]
public abstract class Actor : Pausable {

    public CommandGenerator command_generator;

    [HideInInspector]
    public Collider2D actor_collider_2d;

    // Use this for initialization
    protected virtual void Awake () {
        actor_collider_2d = GetComponent<Collider2D>();
    }

    protected virtual void Update()
    {
        var command = command_generator.get_next_command();
        command.execute(this);
    }

    
    public abstract void click();
    public abstract void move(Vector3 target_pos);
    public virtual void do_enable_actor(bool value)
    {
        enabled = value;
    }
}
