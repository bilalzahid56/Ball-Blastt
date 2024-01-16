using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //public Rigidbody2D coinsAll;
    //public Rigidbody2D coinsAll1;
   // public Rigidbody2D coinsAll2;
  //  public Rigidbody2D coinsAll3;
    public GameObject secondBombArea;
    public GameObject bomb;
    public GameObject rocket;
    public GameObject bombArea;
    public GameObject player;
    private float horizontal;
    private float speed = 8;
    private Vector3 reset1 = new Vector3(-7.5f, -3.56f, 0);
    private Vector3 reset2 = new Vector3(7.5f, -3.56f, 0);
    public int health = 4;
   // public GameObject[] coins;
    //float mytimeFact = 0;
    // float myTimeScale;
    // public bool timestop = false;
    public bool rocketTouch = false;
    private bool isFrozen = false;
    private Rigidbody2D rb2;
    public Rigidbody2D rb2COins;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
        DontMoveFromWall();


       



    }
 
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("MultiBomb"))
        {

            bomb.SetActive(true);
            // if (rocketTouch)
            // {

                InvokeRepeating("SecondBombShow", 0.04f, 0.04f);
                Invoke("SecondBombDisappear", 5);
            // }
            // 

            // }
            //
            //
            Debug.Log("ss");
          
        }
        if (collision.gameObject.CompareTag("Timer"))
        {
            if (!isFrozen)
            {
               
                Invoke("FreezeObjectsForDuration", 0f);

                
                isFrozen = true;
            }
           
        }
       
        if(collision.gameObject.CompareTag("ROcketBox"))
        {
            Debug.Log("dd");
            Invoke("rocketFLy", 0.5f);
            Invoke("rocketFLy", 1.0f);
            Invoke("rocketFLy", 1.5f);
        }
    }

    void FreezeObjectsForDuration()
    {
        
        Rigidbody2D[] allRigidbodies2D = FindObjectsOfType<Rigidbody2D>();
        foreach (Rigidbody2D otherRb2D in allRigidbodies2D)
        {
            if (otherRb2D != rb2 && otherRb2D != rb2COins)
            {
                otherRb2D.bodyType = RigidbodyType2D.Static;
            }
        }

        // After 5 seconds, unfreeze all objects
        Invoke("UnfreezeObjects", 7f);
    }

    void UnfreezeObjects()
    {
        Rigidbody2D[] allRigidbodies2D = FindObjectsOfType<Rigidbody2D>();
        foreach (Rigidbody2D otherRb2D in allRigidbodies2D)
        {
            if (otherRb2D != rb2 && otherRb2D != rb2COins)
            {
                otherRb2D.bodyType = RigidbodyType2D.Dynamic;
            }
        }

        // Reset the flag to allow collisions again
        isFrozen = false;
    }


  /*  private void Reset()
    { 
        coinsAll.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        coinsAll1.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        coinsAll2.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        coinsAll3.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }*/
    void rocketFLy()
    {
        Instantiate(rocket, bombArea.transform.position, bombArea.transform.rotation);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin1"))
        {
            health -= 1;
            if(health ==0)
            {
                SceneManager.LoadScene(0);
            }
        }
        if (collision.gameObject.CompareTag("Fission"))
        {
            health -= 1;
            if (health == 0)
            {
                SceneManager.LoadScene(0);
            }
        }
        
    }
    private void DontMoveFromWall()
    {
        if (transform.position.x < -7.5f)
        {
            transform.position = reset1;
        }
        if (transform.position.x > 7.5f)
        {
            transform.position = reset2;
        }
    }
    void SecondBombShow()
    {
       // bomb.SetActive(true);
        Instantiate(bomb, secondBombArea.transform.position, secondBombArea.transform.rotation);
    }
    void SecondBombDisappear()
    {
        bomb.SetActive(false);
       // Destroy(bomb);
    }

}
