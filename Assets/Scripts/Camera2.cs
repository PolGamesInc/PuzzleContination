using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera2 : MonoBehaviour
{

    public string NumberScene;

    private void Update()
    {
        if(transform.position.z == -69.83948f)
        {
            SceneManager.LoadScene(NumberScene);
        } 
    }
}
