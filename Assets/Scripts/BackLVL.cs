using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLVL : MonoBehaviour
{
    public string NumberScene;

  public void OnClick()
    {
        SceneManager.LoadScene(NumberScene);
    }
}
