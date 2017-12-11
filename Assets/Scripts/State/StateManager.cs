using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {

    [HideInInspector]
    public State current_state;
    public Animator tutorial_animator;
    public TutorialState tutorial_state;
    public PlayState play_state;

	// Use this for initialization
	void Start () {
        current_state = new TutorialState(this,tutorial_animator);
        play_state = new PlayState(this);

    }
	
	// Update is called once per frame
	void Update () {
        current_state.update();
    }


}
