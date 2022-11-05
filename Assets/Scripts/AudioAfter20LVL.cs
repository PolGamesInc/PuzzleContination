using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAfter20LVL : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
