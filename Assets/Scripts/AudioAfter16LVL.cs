using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioAfter16LVL : MonoBehaviour
{
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "20LVL")
        {
            Destroy(this.gameObject);
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
