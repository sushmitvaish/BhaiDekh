using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene1Back : MonoBehaviour {

	// Use this for initialization
	public void ButtonClick()
	{
		SceneManager.LoadScene ("Scene1");
	}
}
