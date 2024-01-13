using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBomb : MonoBehaviour
{
   // public GameObject secondBombArea;
    public GameObject bomb;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Bomb()
    {
        
        //Instantiate(bomb, secondBombArea.transform.position, secondBombArea.transform.rotation);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            InvokeRepeating("Bomb", 0.1f, 0.05f);
        }
    }
}
