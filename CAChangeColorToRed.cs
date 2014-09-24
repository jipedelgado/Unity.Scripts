using UnityEngine;
using System.Collections;

public class CAChangeColorToRed :  CustomActionScript {

	public Rigidbody _targetRigidbody = null;
	public Color _couleur ;

	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{
		yield return new WaitForFixedUpdate();
		_targetRigidbody.renderer.material.color = Color.red;
		yield return null;
	}
}
