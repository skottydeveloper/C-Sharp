using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space)) {
			//Load that level

			SceneManager.LoadScene ("Tutorial", LoadSceneMode.Single);
		}

	}
}
