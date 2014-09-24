using UnityEngine;
using System.Collections;

public class ZoomCamera : MonoBehaviour {

	void OnGUI() {
		if(Input.GetAxis("Mouse ScrollWheel") != 0)
		{
			Debug.Log (" roulette souris detectée ------------------------------ = " + Input.GetAxis("Mouse ScrollWheel"));
			transform.Translate(1.1f * Vector3.down);
		}

	}
	void FixedUpdate(){

	}
}