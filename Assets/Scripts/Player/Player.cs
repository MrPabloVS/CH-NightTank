using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    //public int speed = 1000;
    public static bool finished = false;
    public float hoverForce = 4.0f;
    [SerializeField] public UnityEvent onFinish;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



     private void FixedUpdate() {
        Movimiento();
    }

    void Movimiento() {
        

        rb.AddForce(Input.GetAxis("Horizontal") * transform.right * hoverForce);   
        rb.AddForce(Input.GetAxis("Vertical") * transform.forward * hoverForce);
     

    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("GANASTE!!!!");
            finished = true;
            OnFinishHandler();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            ManageDeath();
        }
    }

    public void ManageDeath()
    {
        gameObject.transform.position = new Vector3(0,0,0);
    }

    void OnFinishHandler() 
    {
        onFinish.Invoke();
    }
}
