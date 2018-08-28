using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	float rotSpeed = 60;

	void OnMouseDrag(){
		float rotX = Input.GetAxis ("Mouse X") * rotSpeed * Mathf.Deg2Rad;
		float rotY = Input.GetAxis ("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
		float rotZ = Input.GetAxis ("Mouse Z") * rotSpeed * Mathf.Deg2Rad;
		transform.Rotate (Vector3.up, -rotX);
		transform.Rotate (Vector3.right, rotY);
		transform.Rotate (Vector3.up, rotZ);
	}
}
