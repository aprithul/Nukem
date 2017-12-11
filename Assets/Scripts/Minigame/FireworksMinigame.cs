﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksMinigame : MinigameController {

    public Firecracker firecracker_actor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected override void Update () {
        if (game_ended)
            return;

        base.Update();
        if (firecracker_actor.lit)
            end_game(true);
	}
}
