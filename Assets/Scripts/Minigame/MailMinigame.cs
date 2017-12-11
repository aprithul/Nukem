using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailMinigame : MinigameController {

    public Mail mail;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    protected override void Update () {
        if (game_ended)
            return;
        base.Update();

        if (mail.read)
            end_game(true,2f);
	}
}
