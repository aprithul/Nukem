using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Actor {

    public Sprite[] sprites;
    [HideInInspector]
    public bool is_on;
    public override void click()
    {
        is_on = !is_on;
        GetComponent<SpriteRenderer>().sprite = is_on ? sprites[1] : sprites[0];
    }

    public override void move(Vector3 target_pos)
    {

    }

    // Use this for initialization
    void Start () {
		
	}

}
