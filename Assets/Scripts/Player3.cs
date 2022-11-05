using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player3 : MonoBehaviour
{
    [SerializeField] private Transform portal2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PortalWith"))
        {
            transform.position = portal2.position;
        }
    }

}
