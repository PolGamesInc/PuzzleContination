using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class PrevScene : MonoBehaviour
{
    public string numberScene;

    public void OnClick()
    {
        SceneManager.LoadScene(numberScene);
    }

}
