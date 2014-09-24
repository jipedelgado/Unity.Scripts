using UnityEngine;
using System.Collections;

public class EnableComponent : MonoBehaviour {

	private Light myLight;

	void Start () {
		myLight = GetComponent<Light> ();
	}

	void Update () {
		if(Input.GetKeyUp(KeyCode.Space))
		{
			Debug.Log("touche <espace> pressée");
			myLight.enabled = !myLight.enabled;
		}
	}
}
