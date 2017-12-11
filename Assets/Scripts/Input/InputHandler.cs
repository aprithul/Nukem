using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : CommandGenerator {

    public static EventHandler on_clicked;

    // Use this for initialization
    void Start()
    {

    }

    private void Update()
    {
        if (is_paused)
            return;

        if (on_clicked != null && Input.GetMouseButtonDown(0))
            on_clicked(this, EventArgs.Empty);
    }

    public override Command get_next_command()
    {
        if (is_paused)
            return empty_command;

        if (Input.GetMouseButtonDown(0))
        {
            var mouse_to_word_pos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return new ClickDownCommand(mouse_to_word_pos);
        }
        else if (Input.GetMouseButton(0))
        {
            var mouse_to_word_pos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return new MouseDragCommand(mouse_to_word_pos);
        }

        return empty_command;
    }

    

}
