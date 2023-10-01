using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToTheNextLevelFinal : MonoBehaviour {

	public int SceneToLoad;

	public void LevelLoader()
	{
		//Application.LoadLevel(SceneToLoad);
		SceneManager.LoadScene ("Level1");
	}
}