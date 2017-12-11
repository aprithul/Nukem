using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : Actor {

    protected override void Awake()
    {
        base.Awake();
    }

    public override void click()
    {
    }

    public override void move(Vector3 target_pos)
    {
        //target_pos.x = Mathf.Clamp(target_pos.x, starting_pos.x, starting_pos.x + 1f);
        //target_pos.y = starting_pos.y;
        var start_pos = transform.position;
        var pos = target_pos;
        pos.y = start_pos.y;
        pos.x = Mathf.Clamp(target_pos.x, -0.6f, 0.8f);
        transform.position = pos;
    }

    // Use this for initialization
    void Start () {
		
	}
	
}
