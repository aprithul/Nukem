using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nukem : MinigameController {

    public Switch nuke_switch;
    public Animator world_animator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected override void Update () {

        if (game_ended)
            return;

        if (nuke_switch.is_on)
            StartCoroutine(nuked());

	}

    IEnumerator nuked()
    {
        game_ended = true;
        timer_text_mesh.text = "Launched !!!";
        yield return new WaitForSeconds(1f);
        animation_controller.SetTrigger("shoo");
        world_animator.SetTrigger("nuke");


    }
}
