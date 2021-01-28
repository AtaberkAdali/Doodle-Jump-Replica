using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    static Music Tekmusic = null;
    void Start()
    {
        if(Tekmusic != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Tekmusic = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}
