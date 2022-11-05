using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0f, 60f, 0f) * Time.deltaTime);
    }
}
