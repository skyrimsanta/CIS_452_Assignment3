/*
 * (Levi Schoof)
 * (Minion)
 * (Assignment 3)
 * (Implament the IObserver and handles the backwards minion movement)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMinion : IObserver
{
    MovementData movementData;
    Vector3 direction;
    Vector3 newPos;
    public float speed = 10;

    private void Start()
    {
        movementData = FindObjectOfType<MovementData>();
        direction = Vector3.zero;

        movementData.RegisterObserver(this);
    }

    public override void UpdateMovement(Vector3 dir)
    {
        Debug.Log("Update Movement is being called on minions " + dir);
        this.direction = dir;
    }

    private void FixedUpdate()
    {
        newPos = this.transform.position;
        newPos += (-direction * speed * Time.deltaTime);

        this.transform.position = newPos;
    }

    private void OnDestroy()
    {
        movementData.RemoveObserver(this);
    }
}
