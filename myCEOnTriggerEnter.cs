using UnityEngine;
using System.Collections;

public class myCEOnTriggerEnter : CustomEventScript {

	// Use this for initialization
	void OnTriggerEnter(Collider col) {
		Debug.Log (" myCEOnTriggerEnter accessed");
		OnTriggered(this, col.gameObject);
	}
}
