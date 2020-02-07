/*
 * (Levi Schoof)
 * (ISubject)
 * (Assignment 3)
 * (Subject interface(Abstract Class))
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ISubject : MonoBehaviour
{
    public abstract void RegisterObserver(IObserver newObserver);
    public abstract void RemoveObserver(IObserver oldObserver);
    public abstract void NotifyObservers();

}
