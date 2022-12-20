using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannons : MonoBehaviour
{
    public float cooldown = 0f;
    public int shootAmount = 0;

    public GameObject BulletN;
    public GameObject BulletS;
    public GameObject BulletE;
    public GameObject BulletW;
	public Transform salidaN;
    public Transform salidaS;
    public Transform salidaE;
    public Transform salidaW;

    private void Update()
    {
        cooldown -= Time.deltaTime;

        if (cooldown < 0f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
		    {
			    Shoot();
		    }
        }
       
		
    }
	
	private void Shoot()
	{
		Debug.Log("The Cannon has been shoot!");

		Instantiate(BulletN,salidaN.position,transform.rotation);
        Instantiate(BulletS,salidaS.position,transform.rotation);
        Instantiate(BulletW,salidaW.position,transform.rotation);
        Instantiate(BulletE,salidaE.position,transform.rotation);
        cooldown = 3f;

	}

    public void addShoots()
    {
        shootAmount += 1;
    }
}
