using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : Actor {
    [HideInInspector]
    public bool broken = false;
    public Sprite[] sprites;
    private int state = 0;

    public override void click()
    {
        if (state == 2)
            broken = true;
        else
            GetComponent<SpriteRenderer>().sprite = sprites[state++];
        
    }

    public override void move(Vector3 target_pos)
    {

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();
	}
}
