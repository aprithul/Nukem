using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class highscore : MonoBehaviour 
{

	// Use this for initialization
	Text[] txt;
	public GameObject row;
	public GameObject container;
	void Start () 
	{
		for (int i = 0; i < 50; i++) 
		{
			GameObject obj = Instantiate (row, transform.localPosition, Quaternion.identity) as GameObject;
			txt = obj.GetComponentsInChildren<Text> ();
			if (txt.Length == 3) {
			
				txt [0].text = "" + (i + 1);
				txt [1].text = "your_name";
				txt [2].text = "your_score";
			
			}
			obj.transform.SetParent(container.transform,false);
		}
	}
	

	void Update () 
	{
		
	}
}
