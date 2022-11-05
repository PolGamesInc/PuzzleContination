using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player3End : MonoBehaviour
{
    [SerializeField] private GameObject Camera3;
    [SerializeField] private GameObject Player1;
    [SerializeField] private GameObject ButtonContine;
    [SerializeField] private GameObject ButtonAtack;
    [SerializeField] private GameObject ButtonLive;
    [SerializeField] private GameObject TextSphere;
    [SerializeField] private GameObject TextSphere1;
    [SerializeField] private GameObject TextSphere2;

    public string NumberScene;

    public void OnClick()
    {
        SceneManager.LoadScene(NumberScene);
    }

    private void Update()
    {
        if(transform.position.z == 4.76f)
        {
            Camera3.SetActive(true);
            Player1.transform.position = new Vector3(-0.94f, 0.13f, 4.73f);
            ButtonContine.SetActive(true);
            ButtonAtack.SetActive(false);
            ButtonLive.SetActive(false);
            TextSphere.SetActive(false);
            TextSphere1.SetActive(false);
            TextSphere2.SetActive(false);
        }
    }
}
