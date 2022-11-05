using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class Player2 : MonoBehaviour
{
    [SerializeField] private Vector3 moveDirectionZ;
    [SerializeField] private Vector3 moveDirectionX;

    [SerializeField] private Transform portal2;

     public GameObject enemy;

    public void OnClickUp()
    {
        GetComponent<Rigidbody>().velocity += moveDirectionZ;
    }
    public void OnClickDown()
    {
        GetComponent<Rigidbody>().velocity -= moveDirectionZ;
    }
    public void OnClickRight()
    {
        GetComponent<Rigidbody>().velocity += moveDirectionX;
    }
    public void OnClickLeft()
    {
        GetComponent<Rigidbody>().velocity -= moveDirectionX;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemy.SetActive(false);
        }
        
        if (other.CompareTag("Portal1"))
        {
            transform.position = portal2.position;
        }
    }
}
