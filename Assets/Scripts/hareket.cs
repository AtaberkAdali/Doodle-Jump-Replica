using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hareket : MonoBehaviour
{
    public float movment = 0f;
    public float hareketHizi = 2f;
    Rigidbody2D rb;
    public Text bestPuanim;
    public Text puanimm;
    public int puan = 0;
    public int ziplamaHakki=2;
    public float jumpPower;
    const string BESTT = "Besstt";
    void Start()
    {
        puanimm.text = puan.ToString();
        rb = GetComponent<Rigidbody2D>();
        bestPuanim.text = PlayerPrefs.GetInt(BESTT).ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Yildiz")
        {
            puan += 25;
            puanimm.text = puan.ToString();
            Destroy(collision.gameObject);
        }
        if(collision.tag == "Bitir")
        {
            puan += 750;
            puanimm.text = puan.ToString();
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (PlayerPrefs.GetInt(BESTT) < puan)
        {
            PlayerPrefs.SetInt(BESTT, puan);
            bestPuanim.text = PlayerPrefs.GetInt(BESTT).ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        movment = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (ziplamaHakki > 0)
            {
                rb = GetComponent<Rigidbody2D>();
                Vector2 veloct = rb.velocity;
                veloct.y = jumpPower;
                rb.velocity = veloct;
                ziplamaHakki--;
            }
        }
    }
    private void FixedUpdate()
    {
        Vector2 veloc = rb.velocity;
        veloc.x = movment * hareketHizi;
        rb.velocity = veloc;
    }
}
