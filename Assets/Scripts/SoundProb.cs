using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundProb : MonoBehaviour
{ 
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "5LVL")
        {
            Destroy(this.gameObject);
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}