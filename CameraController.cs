using UnityEngine;
using System.Collections;

/* version du 25 septembre 2014
 * Centre la caméra sur le barycentre de l'ensemble des gameObjects
 * taggés comme "MassiveObjectTag"
 * et fixe la taille de l'image selon les valeurs extrèmes 
 * des positions de ces GameObjects
 */

public class CameraController : MonoBehaviour {

	public GameObject objet1;
	public GameObject objet2;

	private Vector3 offset;
	private GameObject[] attracteurs;

	void Start () {
		offset = transform.position;
		attracteurs = GameObject.FindGameObjectsWithTag("MassiveObjectTag");
	}
	
	void LateUpdate () {
		transform.position = Barycenter (attracteurs) + offset;
		camera.orthographicSize = viewSize (attracteurs);
	}

	Vector3 Barycenter(GameObject[] g){
		Vector3 sigmaMassePosition = Vector3.zero;
		float sigmaMasses = 0.0f;
		foreach (GameObject obj in attracteurs) {
			sigmaMassePosition += obj.transform.position * obj.rigidbody.mass;
			sigmaMasses += obj.rigidbody.mass;
		}
		if (sigmaMasses != 0) 
			return sigmaMassePosition / sigmaMasses;
		else 
			return Vector3.zero;
	}

	float viewSize(GameObject[] g)	{
		float size = 0.0f;
		float Xmin = 99999;
		float Xmax = -99999;
		float Ymin = 99999;
		float Ymax = -99999;

		float x, y;
		foreach (GameObject obj in attracteurs) {
			x = obj.transform.position.x;
			if(x > Xmax) Xmax = x;
			if(x < Xmin) Xmin = x;

			y = obj.transform.position.y;
			if(y > Ymax) Ymax = y;
			if(y < Ymin) Ymin = y;
		}
		if (Xmax - Xmin > Ymax - Ymin)
			size = Xmax - Xmin;
		else 
			size = Ymax - Ymin;
		return size;
	}
}
