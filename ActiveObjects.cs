using UnityEngine;
using System.Collections;

public class ActiveObjects : MonoBehaviour {
	
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) ) {
			gameObject.SetActive(false);
		}
	}
}
