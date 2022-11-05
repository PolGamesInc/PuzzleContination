using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenScene : MonoBehaviour
{
    public string NumberScene;

    private void Update()
    {
        if (transform.position.x == -0.5248728f)
        {
            SceneManager.LoadScene(NumberScene);
        }
    }

}
