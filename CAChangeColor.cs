using UnityEngine;
using System.Collections;

public class CAChangeColor :  CustomActionScript {

	public Rigidbody _sourceRigidbody = null;
	public Rigidbody _targetRigidbody = null;

	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{
		yield return new WaitForFixedUpdate();
		_targetRigidbody.renderer.material.color = _sourceRigidbody.renderer.material.color;
		yield return null;
	}
}
