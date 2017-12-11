using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelescopeMinigame : MinigameController {

    public Cheese target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected override void Update () {
        if (game_ended)
            return;

        base.Update();
        if (target.found)
            end_game(true);
	}
}
