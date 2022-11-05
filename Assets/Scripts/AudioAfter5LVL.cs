using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioAfter5LVL : MonoBehaviour
{
    private void Update()
    { 
        if (SceneManager.GetActiveScene().name == "8LVL")
        {
          Destroy(this.gameObject);
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}