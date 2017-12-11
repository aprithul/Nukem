using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyUtils;

public class ClothMinigame : MinigameController {

    public SnapToTarget_ snap_to_target;
    
	// Use this for initialization
	void Start () {
		
	}


    // Update is called once per frame
    protected override void Update ()
    {
        if (game_ended)
            return;

        base.Update();
        if (snap_to_target && snap_to_target.is_snapped)
            end_game(true);
	}
}
