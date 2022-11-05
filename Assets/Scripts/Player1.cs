using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    [SerializeField] private Vector3 MoveDirectionZ;
    [SerializeField] private Vector3 MoveDirectionX;
    [SerializeField] private GameObject Wall;
    [SerializeField] private GameObject Player4;
    [SerializeField] private GameObject Plat1;
    [SerializeField] private GameObject Plat2;
    [SerializeField] private GameObject Plat3;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private GameObject TextEnemy;
    [SerializeField] private GameObject TextEnemy1;
    [SerializeField] private GameObject TextEnemy2;
    [SerializeField] private GameObject TextPink;
    [SerializeField] private GameObject ButtonLeav;
    [SerializeField] private GameObject ButtonAtack;
    [SerializeField] private AudioSource AudioBOOM;
    [SerializeField] private AudioSource AudioSelectKey;


    public string NumberScene;

    public Transform Portal2;

    public int CountKeys;
    [SerializeField] private int OriginalCount;

    public Text CountKeysText;

    private void Start()
    {
        Plat1.SetActive(true);
        Plat2.SetActive(false);
        Plat3.SetActive(false);
        CountKeys = 0;
        CountKeysText.text = "" + CountKeys.ToString();
    }

    public void OnClick()
    {
        transform.position = new Vector3(-7.13f, 0.13f, 4.26f);
        Enemy.SetActive(false);
        TextEnemy.SetActive(false);
        TextEnemy1.SetActive(false);
        TextEnemy2.SetActive(false);
        TextPink.SetActive(true);
        ButtonLeav.SetActive(false);
        ButtonAtack.SetActive(false);
    }

    public void OnClickUp()
    {
            GetComponent<Rigidbody>().velocity += MoveDirectionZ;
    }

    public void OnClickDown()
    {
            GetComponent<Rigidbody>().velocity -= MoveDirectionZ;
    }
    public void OnClickRight()
    {
            GetComponent<Rigidbody>().velocity += MoveDirectionX;
    }
    public void OnClickLeft()
    {
            GetComponent<Rigidbody>().velocity -= MoveDirectionX;
    }

    private void Update()
    {
        if(CountKeys == OriginalCount)
        {
            Wall.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Plat1":
                Player4.transform.position = new Vector3(-6.96f, 0.5f, 7.32f);
                Plat1.SetActive(false);
                Plat2.SetActive(true);
                AudioBOOM.Play();
            break;
            case "Plat2":
                Player4.transform.position = new Vector3(11.57f, 0.5f, 6.918f);
                Plat2.SetActive(false);
                Plat3.SetActive(true);
                AudioBOOM.Play();
                break;
            case "Plat3":
                Player4.transform.position = new Vector3(-10.68f, 0.5f, -6.11f);
                AudioBOOM.Play();
                break;
            case "Key":
                AudioSelectKey.Play();
                CountKeys++;
                CountKeysText.text = "" + CountKeys.ToString();
                break;
            case "Enemy":
                transform.position = new Vector3(-14f, 0.5f, 5.8f);
                break;
            case "LVL_Zone":
                SceneManager.LoadScene(NumberScene);
                break;
            case "PortalPerpal":
                transform.position = new Vector3(Portal2.position.x, transform.position.y, Portal2.position.z);
                break;
        }
    }

}