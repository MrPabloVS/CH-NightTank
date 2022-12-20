using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLine : MonoBehaviour
{
    public float maxDistance = 50f;
    public LayerMask layerToCollide;
    public UnityEngine.Vector3 direction;
    public GameObject salida;
    private bool isActive = true;
    public static float timer = 0f;
    public static bool startTimer = false;


   
    void Update()
    {
        Raycast();
        updateTimer();
    }

    void Start()
    {
        timer = 0f;
        isActive = true;
    }

    private void Raycast()
    { 

        RaycastHit hit;
        

        // if (Physics.Raycast(transform.position, direction, out hit, maxDistance, layerToCollide))
        // {
        //     Debug.Log(hit.distance);

        // }
        if (Physics.Raycast(salida.transform.position, direction, out hit, Mathf.Infinity, layerToCollide) && isActive)
        {
            Debug.DrawRay(salida.transform.position, direction * hit.distance, Color.yellow);
            Debug.Log("Timer Start");
            isActive = false;
            startTimer = true;

        }
        else
        {
            Debug.DrawRay(salida.transform.position, direction * 1000, Color.white);
            //Debug.Log("Did not Hit");
        }
    

    }

    public void updateTimer()
    {
        if (startTimer)
        {
            timer += Time.deltaTime;
        }
    }
}
