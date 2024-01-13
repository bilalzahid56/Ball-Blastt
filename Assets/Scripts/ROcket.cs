using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROcket : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject explosive;
    private float speed = 6;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up*speed*Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WallUp"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Coin1"))
        {
            Explosive();
            Destroy(this.gameObject);

        }
        if (collision.gameObject.CompareTag("Fission"))
        {
            Explosive();
            Destroy(this.gameObject);
        }
    }
    void Explosive()
    {
        Instantiate(explosive,transform.position,transform.rotation);
    }
}
