using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public Pausable[] pausable_gameobjects;
    private bool is_paused;

    private void Awake()
    {

    }

    public void pause()
    {
        is_paused = !is_paused;
        foreach (Pausable pausable in pausable_gameobjects)
            pausable.Pause(is_paused);
    }

    public void open_scene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("quiting");
    }
    
    
}
