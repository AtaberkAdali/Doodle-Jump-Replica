using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kiril : MonoBehaviour
{
    public float jumpPower = 10f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb.velocity.y < 0 || rb.velocity.y == 0)
        {
            if (rb != null)
            {
                Vector2 veloc = rb.velocity;
                veloc.y = jumpPower;
                rb.velocity = veloc;
                Destroy(gameObject);
                //rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            }
        }
    }
}
