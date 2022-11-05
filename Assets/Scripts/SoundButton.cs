using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    [SerializeField] private AudioSource Audio;
    [SerializeField] private AudioClip Button;
    public void OnClick()
    {
        Audio.clip = Button;
        Audio.Play();
    }
}
