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
        onDeathHandler();
        onWinHandler();
        onBoobyHitHandler();
        onShootHandler();
        onStartHandler();
    }
    

    public void onDeathHandler() 
    {
        if (Player.isDeath)
        {
            Debug.Log("You have died");
            onDeath.Invoke();
        }
        
    }

    public void onEscHandler()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            onEsc.Invoke();
            Debug.Log("Invocando onEsc");
        }
    }

    public void onWinHandler()
    {
        if (Player.finished)
        {
            onWin.Invoke();
            Debug.Log("Invocando victoria");
        }
    }

    public void onBoobyHitHandler()
    {
        if (BoobyTrap.didHit)
        {
            onBoobyHit.Invoke();
            Debug.Log("Invocando BoobyHit");
        }
    }

    public void onShootHandler()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onShoot.Invoke();
            Debug.Log("Invocando onEsc");
        }
    }

    public void onStartHandler()
    {
        if (StartLine.startTimer)
        {
            onStart.Invoke();
            Debug.Log("invocar onStart");
        }
    }
}
