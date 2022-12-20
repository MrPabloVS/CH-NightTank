using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EnemyBullet : Bullets
{

    [SerializeField] public UnityEvent onHit;

    

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
       Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
            OnHitHandler();
            
        }

        if (other.gameObject.tag == "Wall")
        {
            
            Destroy(gameObject);
            
        }
        
    }

    void OnHitHandler() 
    {
        onHit.Invoke();
    }
}
