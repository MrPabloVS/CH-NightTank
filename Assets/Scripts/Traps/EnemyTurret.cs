using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : MonoBehaviour
{
    public float cooldown = 0f;
    public Transform salida;
    public GameObject Bullet;

     private void Update()
    {
        cooldown -= Time.deltaTime;

        if (cooldown < 0f)
        {
            Shoot();
        }
       
		
    }
	
	private void Shoot()
	{

		Instantiate(Bullet,salida.position,transform.rotation);
        cooldown = 5f;

	}

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Torreta:" + other.gameObject.tag);
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Torreta:" + other.gameObject.tag);
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }

}
