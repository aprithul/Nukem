using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : Pausable 
{
    
	public float speed;
	public bool rotate;
	public Transform clock_dial;

    protected bool is_paused;

	void Start () 
	{

	}

	void Update () {

        if (is_paused)
            return;

        if (rotate)
            clock_dial.transform.Rotate(Vector3.forward * speed * -1);
    }

	public bool Press()
	{
		double	rotationValue = clock_dial.transform.rotation.eulerAngles.z;
		if (rotationValue > 0 && rotationValue < 60) 
		{
			return true;
		}
		else 
		{
            clock_dial.transform.rotation = Quaternion.identity;
            return false;
		}

	}

    public override void Pause(bool value)
    {
        is_paused = value;
    }
}