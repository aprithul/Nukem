using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mail : Actor {

    public Sprite[] sprites;
    [HideInInspector]
    public bool read;

    public override void click()
    {
        if (!read)
            read = true;

        if (read)
            GetComponent<SpriteRenderer>().sprite = sprites[1];
        else
            GetComponent<SpriteRenderer>().sprite = sprites[0];
    }

    public override void move(Vector3 target_pos)
    {

    }

    // Use this for initialization
    void Start () {
		
	}

}
