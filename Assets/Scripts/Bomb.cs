using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Rigidbody2D bombRb;
    
    private  float speed = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        bombRb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WallUp"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Coin1"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Fission"))
        {
            Destroy(this.gameObject);
        }
    }
}
