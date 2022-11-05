using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioAfter8LVL : MonoBehaviour
{

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "10LVL")
        {
            Destroy(this.gameObject);
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}