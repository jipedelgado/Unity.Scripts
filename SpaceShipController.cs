using UnityEngine;
using System.Collections;

public class SpaceShipController : MonoBehaviour {

	public float acceleration = 0;

	void Start(){
		//rigidbody.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
	}

	void OnGUI() {
		rigidbody.velocity *= 1 + Input.GetAxis ("Mouse ScrollWheel") * acceleration;
	}



	void FixedUpdate () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			rigidbody.velocity *= 1 + acceleration;

		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			rigidbody.velocity *= 1 - acceleration;
		}

	}
}
