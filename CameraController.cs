using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject objet1;
	public GameObject objet2;
	private Vector3 offset;

	void Start () {
		offset = transform.position;
	}
	
	void LateUpdate () {
		transform.position = Barycenter (objet1, objet2) + offset;
	}

	Vector3 Barycenter(GameObject ob1, GameObject ob2){
		return (ob1.transform.position + ob2.transform.position) / 2;
	}
}
