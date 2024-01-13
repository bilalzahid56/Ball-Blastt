using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timerr : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        { 
            Destroy(this.gameObject);
           //Time.timeScale = 0;
            Debug.Log("ff");
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            // Time.timeScale = 0;
            Debug.Log("ff");
        }
    }
}
