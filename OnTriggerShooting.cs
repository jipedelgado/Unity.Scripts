using UnityEngine;
using System.Collections;

public class OnTriggerShooting : CustomActionScript
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
	public int salve = 3;
	private int speed = 10;
    private Inventory inventory;
    
	public override  void  Start ()
    {
        inventory = GetComponent<Inventory>();
		bulletPrefab.renderer.enabled = false;
	}
	  
	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{
		Shoot();
		yield return null;
	}

    void Shoot ()
    {
			if( inventory.myStuff.bullets > 0)
			{
				bulletPrefab.renderer.enabled = true;
				Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
				bulletInstance.AddForce(firePosition.forward * bulletSpeed);
				inventory.myStuff.bullets--;
				bulletPrefab.renderer.enabled = false;
			}
	}
}