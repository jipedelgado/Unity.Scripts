using UnityEngine;
using System.Collections;

public class GravityScript : MonoBehaviour 
{
	public Transform target;
	[Range(-100, 100)] public int speed = 0;
	
	void Update () 
	{
		//Vector3 relativePos = (target.position + new Vector3(0, 0, 2.0f)) - transform.position;
		//Vector3 relativePos = target.position  - transform.position;
		//Quaternion rotation = Quaternion.LookRotation(relativePos);
		Quaternion rotation = Quaternion.LookRotation(target.position  - transform.position);
		Quaternion current = transform.localRotation;
		
		transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
		transform.Translate(0, 0, speed * Time.deltaTime);
	}
}