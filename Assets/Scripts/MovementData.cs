using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementData : ISubject
{
    Vector3 direction;
    public List<IObserver> observers = new List<IObserver>();

    private void Start()
    {
        direction = Vector3.zero;
    }

    private void Update()
    {
        MovementDirection();
    }
    public override void NotifyObservers()
    {
        foreach(IObserver o in observers)
        {
            Debug.Log("Observers have been notified");
            o.UpdateMovement(direction);
        }
    }

    public override void RegisterObserver(IObserver newObserver)
    {
        observers.Add(newObserver);

        NotifyObservers();
    }

    public override void RemoveObserver(IObserver oldObserver)
    {
        if (observers.Contains(oldObserver))
        {
            observers.Remove(oldObserver);
        }
    }

    private void MovementDirection()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = new Vector3(0, 0, 1);
            NotifyObservers();
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            direction = new Vector3(0, 0, -1);
            NotifyObservers();
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction = new Vector3(-1, 0, 0);
            NotifyObservers();
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = new Vector3(1, 0, 0);
            NotifyObservers();
        }
    }
}
