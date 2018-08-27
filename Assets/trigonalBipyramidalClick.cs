using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class trigonalBipyramidalClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)){ // if left button pressed...
			Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				if(hit.collider.name == "Trigonal Bipyramidical")
				{
					SceneManager.LoadScene ("Scene6");
				}
			}
		}
	}
}
