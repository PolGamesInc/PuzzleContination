using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioAfter10LVL : MonoBehaviour
{
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "17LVL")
        {
            Destroy(this.gameObject);
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
