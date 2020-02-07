using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IObserver : MonoBehaviour
{
    public abstract void UpdateMovement(Vector3 dir);
}
