using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableActor : Actor {

    
    public override void click()
    {

    }

    public override void move(Vector3 target_pos)
    {
        transform.position = target_pos;
    }

    public override void do_enable_actor(bool value)
    {
        base.do_enable_actor(value);
    }



    // Use this for initialization
    void Start () {
		
	}
	
}
