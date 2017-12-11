using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialState : State {
    
    private bool is_tutorial_complete = false;
    private Animator tutorial_animator;
    private int tutorial_animation_count = 2;
    private int current_animation_no = 1;
    private bool is_timer_running = false;

    IEnumerator tutorial_timer(float time)
    {
        is_timer_running = true;
        yield return new WaitForSeconds(time);
        is_timer_running = false;
    }

    public TutorialState(StateManager state_manager, Animator animator):base(state_manager)
    {
        InputHandler.on_clicked += on_click;
        this.tutorial_animator = animator;
        this.state_manager.StartCoroutine(tutorial_timer(3.09f));
    }

    private void trigger_animation()
    {
        if (current_animation_no <= tutorial_animation_count)
        {
            tutorial_animator.SetTrigger(current_animation_no.ToString());
            current_animation_no++;
        }
        else
        {
            tutorial_animator.SetTrigger(current_animation_no.ToString());
            to_next_state();
        }
    }

    public override void update()
    {

    }

    private void on_click(object o, EventArgs e)
    {

        if (!is_timer_running)
        {
            this.state_manager.StartCoroutine(tutorial_timer(0.5f));
            trigger_animation();
        }
    }

    protected override void to_next_state()
    {
        state_manager.current_state = state_manager.play_state;
    }


}
