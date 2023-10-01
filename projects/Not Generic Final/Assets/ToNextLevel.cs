using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ToNextLevel : MonoBehaviour {

	static ToNextLevel Instance;

	void Start ()
	{
		if (Instance != null)
		{
			GameObject.Destroy (gameObject);
		}
		else
		{
			GameObject.DontDestroyOnLoad (gameObject);
			Instance = this;
		}
	}

	void Update()
	{
		if (Input.GetKeyUp(KeyCode.Keypad1))
		{
			SceneManager.LoadScene ("Tutorial");
		}
		if (Input.GetKeyUp(KeyCode.Keypad2))
		{
			SceneManager.LoadScene ("Level1");
		}
	}
}