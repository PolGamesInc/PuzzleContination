using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleEnemyWith : MonoBehaviour
{
    public string NumberScene;

    public void OnClick()
    {
        SceneManager.LoadScene(NumberScene);
    }
}
