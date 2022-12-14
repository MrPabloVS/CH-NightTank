using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float Speed = 4f;
    public Vector3 Direction;
    public float Timer = 10f;
     
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
    public void Movimiento(){
        transform.position += Direction * Speed * Time.deltaTime;
    }

     private void OnCollisionEnter(Collision other) {
       
        if (other.gameObject.tag == "Wall")
        {
            
            Destroy(gameObject);
            
        }
        
    }
}
