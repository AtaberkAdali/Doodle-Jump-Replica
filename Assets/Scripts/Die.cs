using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("öldünb");
    }
}
