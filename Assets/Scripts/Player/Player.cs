using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 1000;
    public static bool isDeath = false;
    public static bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento();
    }

     private void FixedUpdate() {
        Movimiento();
    }

    void Movimiento() {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");     

        gameObject.transform.Translate(new Vector3(x,0,z) * speed * Time.deltaTime);

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
        
    }
}
