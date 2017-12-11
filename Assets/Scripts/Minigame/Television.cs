using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Television : MinigameController {

    public Switch wall_switch;
    public Switch tv_switch;
    public GameObject display;

	// Update is called once per frame
	protected override void Update () {
        if (game_ended)
            return;

        base.Update();

        if (wall_switch.is_on && tv_switch.is_on)
        {
            display.SetActive(true);
            end_game(true);
        }
	}
}
