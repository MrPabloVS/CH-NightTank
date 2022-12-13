using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullets
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Timer -= Time.deltaTime;
        Movimiento();
        if (Timer < 0)
        {
            Destroy(gameObject);
        }

        
    }

    private void OnCollisionEnter(Collision other) {
       
        if (other.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
            
        }
        
    }
}
