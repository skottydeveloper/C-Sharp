using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NxtLvl : MonoBehaviour {

	public string level = "Level1";

	// Use this for initialization
	void OnTriggerEnter2D (Collision2D Colider)
	{
		if(Colider.gameObject.tag == "Player")
			SceneManager.LoadScene(level);
	}
}