using UnityEngine;
using System.Collections;

/*
 * version du 25 septembre 2014
 * applique sur l'objet les forces Newtonniennes de tous les objets (sauf lui-meme)
 * taggés comme "MassiveObjectTag"
 */

public class GiveMass : MonoBehaviour {

	public float vitesseInitialeZ = 0.0f;
	public float G = 10.0f;

	private GameObject[] attracteurs;
	private Vector2 R;
	private Vector2 gamma;
	private float Gm;
	private float K;

	void Start(){
		Gm = G * rigidbody.mass;
		rigidbody.velocity = new Vector2 (0.0f, vitesseInitialeZ);
		attracteurs = GameObject.FindGameObjectsWithTag("MassiveObjectTag");
	}

	void LateUpdate () {
		foreach (GameObject obj in attracteurs) {
			R = transform.position - obj.transform.position;
			if(R != Vector2.zero) {
				K = -Gm * obj.rigidbody.mass;
				gamma = K * R.normalized / R.sqrMagnitude;
				rigidbody.AddForce (gamma * Time.deltaTime);
			}
		}
	}
}