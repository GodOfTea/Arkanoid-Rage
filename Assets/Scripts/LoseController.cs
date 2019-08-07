using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseController : MonoBehaviour 
{
	public void OnTriggerEnter2D(Collider2D col)
	{
		SceneManager.LoadScene ("end_menu");
	}

}
