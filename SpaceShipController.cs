using UnityEngine;
using System.Collections;

/* version du 25 septembre 2014
 * Détermine une position initiale au hasard, dans un rectangle donné.
 * Accélère ou déccélère à la roulette de la souris ou par les touches up et down
 */

public class SpaceShipController : MonoBehaviour {

	public float acceleration = 0;
	private Random rand;

	void Start(){
		float xInit, yInit;
		rand = new Random();
		xInit = Random.Range (-200, 200);
		yInit = Random.Range (-100, 100);
		Debug.Log ("xInit = " + xInit + "yInit = " + yInit);
		transform.position =  new Vector3 (xInit, yInit, 0.0f);
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
