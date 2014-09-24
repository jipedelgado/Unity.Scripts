using UnityEngine;
using System.Collections;

public class CAopenHoleOnTriggerEnter : MonoBehaviour {
/* Associé à un GameObject dont la BoxCollider est déclarée isTrigger = true,
 * désactive la BoxCollider de _target onTriggerEnter
 * permettant la traversée de _target par un gameObject dans l'intervalle de temps 
 * compris entre les 2 événements onTriggerEnter et onTriggerExit
 * réactive a BoxCollider de _target onTriggerExit
 * et rend inactif le GameObject auquel ce script est associé
 */

	[SerializeField]

	public GameObject _target;
	private BoxCollider boxCol;

	void Awake() {
		boxCol = _target.GetComponent<BoxCollider>();
	}
	
	public void OnTriggerEnter(Collider col)
	{
		boxCol.enabled = false;
	}

	public void OnTriggerExit(Collider col)
	{
		//_target.collider.enabled = true;
		//this.gameObject.SetActive (false);
		boxCol.enabled = true;
		Destroy (this.gameObject);
	}
}