using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;



public class FinishLine : MonoBehaviour
{

    [SerializeField] public UnityEvent onFinish;

    public static void ChangeScene()
    {
        SceneManager.LoadScene(0);
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
