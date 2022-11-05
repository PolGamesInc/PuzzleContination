using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera3 : MonoBehaviour
{
    public string NumberScene;

   private void Update()
    {
        if (transform.position.z == 0.2486742f)
        {
            SceneManager.LoadScene(NumberScene);
        }
    }
}
