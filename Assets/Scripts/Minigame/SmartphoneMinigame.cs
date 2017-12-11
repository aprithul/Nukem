using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyUtils;

public class SmartphoneMinigame : MinigameController
{
    public SnapToTarget_ snap_object;
    public GameObject unlocked_phone;

    // Update is called once per frame
    protected override void Update()
    {
        if (game_ended)
            return;

        base.Update();

        if (snap_object.is_snapped)
        {
            unlocked_phone.SetActive(true);
            end_game(true, 1.5f);
        }

    }
}
