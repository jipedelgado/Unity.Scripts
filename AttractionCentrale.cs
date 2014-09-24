using UnityEngine;
using System.Collections;

public class AttractionCentrale : MonoBehaviour {

	public GameObject attracteur;
	public float vitesseInitialeZ = 1.0f;
	public float G = 1.0f;

	private Vector3 vitesseInitiale;
	private Vector3 R;
	private Vector3 gamma;
	private float K;
	
	void Start(){

		K = -G * rigidbody.mass * attracteur.rigidbody.mass;
		rigidbody.AddForce (new Vector3(0.0f, 0.0f, vitesseInitialeZ));
	}

	void LateUpdate () {

		R = transform.position - attracteur.transform.position;
		gamma = K * R.normalized / R.sqrMagnitude;
		rigidbody.AddForce (gamma * Time.deltaTime);

		transform.rotation = Quaternion.FromToRotation(Vector3.forward, rigidbody.velocity);
	}

}
