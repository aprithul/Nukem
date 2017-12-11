using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firecracker : Actor {
    [HideInInspector]
    public bool lit;

    public override void click()
    {
        GetComponent<Animator>().SetTrigger("fire");
        lit = true;
    }

    public override void move(Vector3 target_pos)
    {

    }

    // Use this for initialization
    void Start () {
		
	}
	
}
