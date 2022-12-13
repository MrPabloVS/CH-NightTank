using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoobyTrap : MonoBehaviour
{
    public float maxDistance = 50f;
    public LayerMask layerToCollide;
    public UnityEngine.Vector3 direction;
    public GameObject salida;
    public static bool didHit = false;
    private bool isActive = true;

   

    void Update()
    {
        Raycast();
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
            //Debug.Log(hit.collider);
            isActive = false;
            didHit = true;
        }
        else
        {
            Debug.DrawRay(salida.transform.position, direction * 1000, Color.white);
            //Debug.Log("Did not Hit");
        }
    

    }


}
