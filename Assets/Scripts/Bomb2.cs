using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb2 : MonoBehaviour
{
    public Rigidbody2D bombRb;
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        bombRb = GetComponent<Rigidbody2D>();
        bombRb.AddForce(Vector2.up * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
