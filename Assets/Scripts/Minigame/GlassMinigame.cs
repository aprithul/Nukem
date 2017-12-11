using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassMinigame : MinigameController {

    public Glass glass_actor;

	// Update is called once per frame
	protected override void Update () {
        if (game_ended)
            return;

        base.Update();
        if (glass_actor.broken)
            end_game(true);
	}
}
