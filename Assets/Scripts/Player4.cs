using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player4 : MonoBehaviour
{
    [SerializeField] private GameObject Wall;
    [SerializeField] private GameObject Key;
    [SerializeField] private GameObject PinkTXT1;
    [SerializeField] private GameObject PinkTXT12;
    [SerializeField] private GameObject PinkTXT2;
    [SerializeField] private GameObject Camera1;
    [SerializeField] private GameObject Camera2;
    [SerializeField] private GameObject ButtonAtack;
    [SerializeField] private GameObject TextSphere1;
    [SerializeField] private GameObject TextSphere2;
    [SerializeField] private GameObject TextSphere;
    [SerializeField] private GameObject ButtonLeav;
    [SerializeField] private GameObject Player3;

    [SerializeField] private AudioSource AudioBOOM;

    public string NumberScene;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Wall.SetActive(false);
        Key.SetActive(false);
        PinkTXT2.SetActive(false);
    }

    public void OnClic()
    {
        Player3.SetActive(false);
        TextSphere1.SetActive(false);
        TextSphere2.SetActive(false);
        ButtonLeav.SetActive(false);
        TextSphere.SetActive(false);
        ButtonAtack.SetActive(false);
        Camera1.SetActive(false);
        Camera2.SetActive(true);
    }

    public void OnClick()
    {
        rb.constraints = RigidbodyConstraints.None;
    }


    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player")
        {
            AudioBOOM.Play();
            SceneManager.LoadScene(NumberScene);
        }

        switch(other.name)
        {
            case "Platform":
                SceneManager.LoadScene(NumberScene);
                break;
            case "Player1":
                gameObject.SetActive(false);
                Wall.SetActive(true);
                Key.SetActive(true);
                PinkTXT1.SetActive(false);
                PinkTXT2.SetActive(true);
                PinkTXT12.SetActive(false);
                break;
        }
    }
}
