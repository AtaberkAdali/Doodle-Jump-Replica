using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTakip : MonoBehaviour
{
    public Transform doodlem;
    void Update()
    {
        if(doodlem.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, doodlem.position.y, transform.position.z);
        }
    }
}
