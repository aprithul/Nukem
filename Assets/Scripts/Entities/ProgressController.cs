using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProgressController : Actor
{
    public TextMeshPro date;
    public SpriteRenderer dude_sprite_renderer;
    public Sprite[] dude_sprites;
    public int[] timings;
    public MinigameController[] minigames;
    public PopupNotification notification_prefab;
    public ClockController clock;
    public HistoryManager history_manager;
    public Animator world_animation_controller;
    private PopupNotification last_popup;
    private bool is_paused;
    private int timing = 0;
    private int sprite_index = 0;

    protected override void Awake()
    {
        base.Awake();
        do_enable_actor(false);
    }


    public override void click()
    {
        if (is_paused)
            return;

        if(clock.Press())
        {
            GetComponent<Animator>().SetTrigger("bounce");
            if (last_popup != null)
                last_popup.animation_controller.SetTrigger("drop");

            if (history_manager.is_empty())
            {
                is_paused = true;
                date.text = "2017 AD";
                world_animation_controller.SetTrigger("boss");
            }
            else
            {
                var historical_event = history_manager.get_next_event();
                date.text = historical_event.time;
                var popup = Instantiate(notification_prefab, this.transform);
                popup.activate(historical_event.text, Color.green);
                last_popup = popup;
                if (sprite_index < dude_sprites.Length && timing == timings[sprite_index])
                {
                    dude_sprite_renderer.sprite = dude_sprites[sprite_index];
                    sprite_index++;
                }
                timing++;

                if (historical_event.minigame != null)
                {
                    var minigame = historical_event.minigame;
                    minigame.start_minigame(this);
                    do_enable_actor(false);
                }

                clock.speed += 0.17f;
            }
        }
        else
        {
            if (last_popup != null)
                last_popup.animation_controller.SetTrigger("drop");

            GetComponent<Animator>().SetTrigger("bzz");
            var popup = Instantiate(notification_prefab, this.transform);
            popup.activate("Too early !", Color.red);

            last_popup = popup;
        }
    }

    public override void move(Vector3 position)
    {
        
    }

    public override void do_enable_actor(bool value)
    {
        print(value);
        base.do_enable_actor(value);
        clock.enabled = value;

    }

    private MinigameController get_mini_game(string id)
    {
        foreach (MinigameController mgc in minigames)
            if (mgc.minigame_id == id)
                return mgc;
        return null;
    }

    public override void Pause(bool value)
    {
        is_paused = value;
    }

    protected override void Update()
    {
        base.Update();
     
    }
}
