using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class FinishLine : MonoBehaviour
{

    [SerializeField] public UnityEvent onFinish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            Debug.Log("Victoria");
            OnFinishHandler();
            
        }
    }

    void OnFinishHandler()
    {
        onFinish.Invoke();
        Debug.Log("Invocando onFinish");
    }
}
