using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkCube : MonoBehaviour
{
    GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Minion"))
        {
            gm.pinkDone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Minion"))
        {
            gm.pinkDone = false;
        }
    }
}
