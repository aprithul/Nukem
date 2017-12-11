using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public abstract class MinigameController : MonoBehaviour {

    //public static EventHandler on_target_accomplished;
    public bool stay_active = false;
    public float time;
    public string minigame_id;
    public TextMeshPro timer_text_mesh;
    protected Animator animation_controller;
    protected bool game_ended;
    private Actor calling_actor;

    // Use this for initialization
    void Awake() {
        animation_controller = GetComponent<Animator>();
        if(!stay_active)
            gameObject.SetActive(false);
        //on_target_accomplished += end_game;
    }

    public void start_minigame(Actor calling_actor)
    {
        this.calling_actor = calling_actor;
        gameObject.SetActive(true);
    }

    protected virtual void end_game(bool result, float wait=1f)
    {
        game_ended = true;
        StartCoroutine(success(result,wait));
    }

    protected virtual void Update()
    {
        if (time >= 0)
            time -= Time.deltaTime;
        else
            end_game(false);

        timer_text_mesh.text = time.ToString("0.00");
        //timer_text_mesh.GetComponent<TMP_Text>().ForceMeshUpdate();
        
    }

    IEnumerator success(bool result, float wait)
    {
        timer_text_mesh.text = result ? "Success" : "Failure";
        timer_text_mesh.color = result ? new Color(30f/255f, 206f/255f, 108f/255f) : new Color(208f / 255f, 27f / 255f, 27f / 255f);
        timer_text_mesh.ForceMeshUpdate();
        yield return new WaitForSeconds(wait);
        animation_controller.SetTrigger("shoo");
        calling_actor.do_enable_actor(true);
    }
}
