using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private float _movment;

    public Vector3[] positions;

    private int _currentTarget;

    [SerializeField] private GameObject player3;

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, positions[_currentTarget], speed);

        if (transform.position != positions[_currentTarget]) return;
        if (_currentTarget < positions.Length - 1)
        {
            _currentTarget++;
        }
        else
        {
            _currentTarget = 0;
        }
    }
    private void OnMouseDown()
    {
        player3.transform.position = transform.position;
    }

    private void Update()
    {
        if (player3.transform.position == transform.position)
        {
            gameObject.SetActive(false);
        }
    }
}