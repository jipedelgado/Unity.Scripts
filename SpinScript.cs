using UnityEngine;
using System.Collections;

public class SpinScript : MonoBehaviour {

	[Range(-1000, 1000)] public int speed = 0;

	void Update () {
		//transform.Rotate (new Vector3(speed*Time.deltaTime, 0, 0));
		//transform.Rotate ( Vector3.forward * speed*Time.deltaTime);		
		transform.Rotate ( Vector3.up * speed*Time.deltaTime);
	}
}
