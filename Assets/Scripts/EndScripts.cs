using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScripts : MonoBehaviour
{
    [SerializeField] private GameObject Player1;
    [SerializeField] private GameObject Player2;
    [SerializeField] private GameObject Player3;
    [SerializeField] private GameObject Player4;
    [SerializeField] private GameObject TextEnd;

    public float CountEnd;

    private void Start()
    {
        StartCoroutine("YourCoroutine");
        StartCoroutine("YourCoroutine1");
        StartCoroutine("YourCoroutine2");
        StartCoroutine("YourCoroutine3");
        StartCoroutine("YourCoroutineText");
    }
    IEnumerator YourCoroutine()
    {
        yield return new WaitForSeconds(2.5f);
        Player1.SetActive(true);
    }
    IEnumerator YourCoroutine1()
    {
        yield return new WaitForSeconds(5f);
        Player2.SetActive(true);
    }
    IEnumerator YourCoroutine2()
    {
        yield return new WaitForSeconds(7.5f);
        Player3.SetActive(true);
    }
    IEnumerator YourCoroutine3()
    {
        yield return new WaitForSeconds(10f);
        Player4.SetActive(true);
    }
    IEnumerator YourCoroutineText()
    {
        yield return new WaitForSeconds(10f);
        TextEnd.SetActive(true);
    }
}
