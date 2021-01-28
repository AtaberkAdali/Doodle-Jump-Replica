using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnContols : MonoBehaviour
{
    public float kalinlik = 5f;
    public float maxY = 250f;
    private float Xim;
    private float Ym;
    public GameObject prePlatform;
    public GameObject prePlatformKirik;
    public GameObject prePlatformJump;
    public GameObject preYildiz;
    public int kacTaneOlussunDuz = 200;
    public int kacTaneOlussunkirik = 200;
    public int kacTaneOlussunJump = 200;
    public int kacTaneOlussunYildiz = 100;
    private int j = 0;

    private void Start()
    {
        for (j = 0; j < kacTaneOlussunDuz; j++)
        {
            Xim = Random.Range(-kalinlik, kalinlik);
            Ym = Random.Range(0f, maxY);
            Vector3 spawnPozisyonu = new Vector3(Xim, Ym, 0f);
            Instantiate(prePlatform, spawnPozisyonu, Quaternion.identity);
        }
        for (j = 0; j < kacTaneOlussunkirik; j++)
        {
            Xim = Random.Range(-kalinlik, kalinlik);
            Ym = Random.Range(0f, maxY);
            Vector3 spawnPozisyonu = new Vector3(Xim, Ym, 0f);
            Instantiate(prePlatformKirik, spawnPozisyonu, Quaternion.identity);
        }
        for (j = 0; j < kacTaneOlussunJump; j++)
        {
            Xim = Random.Range(-kalinlik, kalinlik);
            Ym = Random.Range(0f, maxY);
            Vector3 spawnPozisyonu = new Vector3(Xim, Ym, 0f);
            Instantiate(prePlatformJump, spawnPozisyonu, Quaternion.identity);
        }
        for (j = 0; j < kacTaneOlussunYildiz; j++)
        {
            Xim = Random.Range((-kalinlik-3), (kalinlik+3));
            Ym = Random.Range(0f, maxY);
            Vector3 spawnPozisyonu = new Vector3(Xim, Ym, 0f);
            Instantiate(preYildiz, spawnPozisyonu, Quaternion.identity);
        }
    }
}
