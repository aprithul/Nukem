using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupNotification : MonoBehaviour {
    
    public TextMeshPro text_mesh;
    public Animator animation_controller;
    private TMP_Text text_component;
    Color white = Color.white;

    private void Awake()
    {
        text_component = GetComponent<TMP_Text>();
    }

    public void activate(string text, Color? color = null)
    {
        Color efctv_color = color ?? Color.white;

        text_component.text = text;
        text_component.color = efctv_color;
        text_component.ForceMeshUpdate();
        animation_controller.SetTrigger("up");
    }

    public void Destroy()
    {
        gameObject.SetActive(false);
    }
}
