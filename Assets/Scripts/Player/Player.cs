using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    //public int speed = 1000;
    public static bool finished = false;
    public float hoverForce = 10.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


     private void FixedUpdate() {
        Movimiento();
    }

    void Movimiento() {
        //float x = Input.GetAxisRaw("Horizontal");
        //float z = Input.GetAxisRaw("Vertical");     
        //Vector3 direction = new Vector3(x, 0.0f, z);

        //gameObject.transform.Translate(new Vector3(x,0,z) * speed * Time.deltaTime);

        //transform.position += direction * speed * Time.deltaTime;

        rb.AddForce(Input.GetAxis("Horizontal") * transform.right * hoverForce);   
        rb.AddForce(Input.GetAxis("Vertical") * transform.forward * hoverForce);
     

    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("GANASTE!!!!");
            finished = true;
        }
    }

    public void ManageDeath()
    {
        gameObject.transform.position = new Vector3(0,0,0);
    }
}
