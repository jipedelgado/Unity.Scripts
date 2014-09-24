using UnityEngine;
using System.Collections;

public class GiveMass : MonoBehaviour {

	public float vitesseInitialeZ = 0.0f;
	public float G = 10.0f;

	private GameObject[] attracteurs;
	private Vector3 R;
	private Vector3 gamma;
	private float Gm;
	private float K;

	void Start(){
		Gm = G * rigidbody.mass;
		rigidbody.velocity = new Vector3 (0.0f, 0.0f, vitesseInitialeZ);
		attracteurs = GameObject.FindGameObjectsWithTag("MassiveObjectTag");
	}

	void LateUpdate () {
		foreach (GameObject obj in attracteurs) {
			R = transform.position - obj.transform.position;
			if(R != Vector3.zero) {
				K = -Gm * obj.rigidbody.mass;
				gamma = K * R.normalized / R.sqrMagnitude;
				rigidbody.AddForce (gamma * Time.deltaTime);
			}
		}
	}
}