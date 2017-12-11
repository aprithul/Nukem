using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtoMainMenu : MonoBehaviour 
{

	// Use this for initialization
	public void backToMain()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
	}

}
