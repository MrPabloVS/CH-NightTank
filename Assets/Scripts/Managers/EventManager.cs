using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
[SerializeField] public UnityEvent onDeath;
[SerializeField] public UnityEvent onEsc;
[SerializeField] public UnityEvent onWin;
[SerializeField] public UnityEvent onBoobyHit;
[SerializeField] public UnityEvent onShoot;
[SerializeField] public UnityEvent onStart;

    private void Update() {
        onEscHandler();
        //onDeathHandler();
        //onBoobyHitHandler();
        //onShootHandler();
       // onStartHandler();
    }
    

   

    public void onEscHandler()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            onEsc.Invoke();
            Debug.Log("Invocando onEsc");
        }
    }


   
}
