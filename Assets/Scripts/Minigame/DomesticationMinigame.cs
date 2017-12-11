using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DomesticationMinigame : MinigameController {

    public Sheep sheep;



    protected override void Update()
    {
        if (game_ended)
            return;

        base.Update();

        if (sheep.transform.position.y > 0f)
            end_game(true);

        if (!sheep.enabled)
            StartCoroutine(delay());

    }


    IEnumerator delay()
    {

        yield return new WaitForSeconds(1f);
        sheep.enabled = true;
    }
}
