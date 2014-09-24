using UnityEngine;
using System.Collections;

public class myCATeleportTarget : CustomActionScript {

	public Transform _teleportTransform;

	public override void OnDrawGizmos()
	{
		base.OnDrawGizmos();
		if (_teleportTransform != null)
			Debug.DrawLine (this.transform.position, _teleportTransform.position, Color.blue);
	}

	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{

		args.transform.position = _teleportTransform.position;
		//Debug.Log ("I was Here !");

		yield return null;
	}

}
