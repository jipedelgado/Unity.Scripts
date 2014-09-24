using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour {

	public Transform seconds;
	public float rayon = 0.2f; 
	private const float secondsToDegrees = 360f / 60f;
	private float theta = 0f;
	private float deltaTheta = 0.1f;
	private float delta = 0f;

	void Update () {
		DateTime time = DateTime.Now;
//		theta = time.Second * secondsToDegrees;
		delta += deltaTheta;
		theta = 2.6f*delta;
		seconds.transform.Translate (Vector3.right * rayon *0.7f * Mathf.Cos ( theta));
		seconds.transform.Translate (Vector3.up * rayon * Mathf.Sin ( theta));
		//seconds.transform.Translate (1f,2f ,0f);
		//seconds.localRotation = Quaternion.Euler(0f, 0f, theta);
	}
}
