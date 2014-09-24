using UnityEngine;
using System.Collections;

public class ToggleColor :  CustomActionScript {

	public Rigidbody _targetRigidbody = null;
	public Color couleur1 = Color.yellow ;
	public Color couleur2 = Color.red ;

	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{
		yield return new WaitForFixedUpdate();
		if(_targetRigidbody.renderer.material.color != couleur1){
			_targetRigidbody.renderer.material.color = couleur1;
		}
		else _targetRigidbody.renderer.material.color = couleur2;
		yield return null;
	}
}
