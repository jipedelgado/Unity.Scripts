using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    
    private Inventory inventory;
    
	void  Awake ()
    {
        inventory = GetComponent<Inventory>();
		//Debug.Log (firePosition.transform.eulerAngles);
		bulletPrefab.renderer.enabled = false;
	}
      
    void Update ()
    {
		Shoot();
    }

    void Shoot ()
    {
        if(Input.GetButtonDown("Fire1") && inventory.myStuff.bullets > 0)
        {
			bulletPrefab.renderer.enabled = true;
			Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            inventory.myStuff.bullets--;
			bulletPrefab.renderer.enabled = false;
        }
    }
}