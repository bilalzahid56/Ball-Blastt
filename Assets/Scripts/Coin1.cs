using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Coin1 : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D rb;
    [SerializeField] protected TMP_Text texthealth;
    [SerializeField]  protected int health;
    [SerializeField] protected float jumpSpeed;
    [SerializeField] protected GameObject[] balls;
    




   // Start is called before the first frame update
   protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        UpdateHealthUI();
        // rb.gravityScale = 0;
        //  StartCoroutine("MoveRight");
        rb.velocity = Vector2.right;
    }
    protected void TakeDamge(int damage)
    {
        if(health > 1)
        {
            health -= damage;
        }
        else
        {
            die();
        }
        UpdateHealthUI();
    }
    IEnumerator MoveRight()
    {
        transform.Translate(Vector2.right*3*Time.deltaTime);
        yield return new WaitForSeconds(3f);
        rb.gravityScale = 1;
    }
   virtual  protected void die()
    {
        ballsSpawn();
        Destroy(this.gameObject);
       
    }
    void ballsSpawn()
    {
        balls[0].transform.SetParent(null);
        balls[1].transform.SetParent(null);
        balls[2].transform.SetParent(null);
        balls[3].transform.SetParent(null);
        balls[0].SetActive(true);
        balls[1].SetActive(true);
        balls[2].SetActive(true);
        balls[3].SetActive(true);
    }

    // Update is called once per frame
    protected void UpdateHealthUI()
    {
        texthealth.text = health.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  if(collision.gameObject.CompareTag("Cannon"))
       // {
       //     SceneManager.LoadScene(0);
      //  }
        if(collision.gameObject.CompareTag("Bomb"))
        {
            TakeDamge(1);
        }
        if(collision.gameObject.CompareTag("Ground"))
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpSpeed);
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
          float  posX = transform.position.x;
            if(posX> 0)
            {
                rb.AddForce(Vector2.left* 100f);
                
            }
            else
            {
                rb.AddForce(Vector2.right * 100f);
            }



        }
        if(collision.gameObject.CompareTag("ROcket"))
        {
            Destroy(gameObject);
        }
    }
}
