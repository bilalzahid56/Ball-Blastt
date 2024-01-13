using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class COin3 : MonoBehaviour
{
    //[SerializeField] private GameObject rocketBox;
    [SerializeField] private  Rigidbody2D rb;
    [SerializeField] private  TMP_Text texthealth;
    [SerializeField] private  int health;
    [SerializeField] private  float jumpSpeed;
    [SerializeField] private  GameObject[] balls;
    [SerializeField] private GameObject coin3;




    // Start is called before the first frame update
   void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        UpdateHealthUI();
        // rb.gravityScale = 0;
        //  StartCoroutine("MoveRight");
        rb.velocity = Vector2.right;
    }
   void TakeDamge(int damage)
    {
        if (health > 1)
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
        transform.Translate(Vector2.right * 3 * Time.deltaTime);
        yield return new WaitForSeconds(3f);
        rb.gravityScale = 1;
    }
     void die()
    {
        ballsSpawn();
        
        coin3.SetActive(false);

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
    void UpdateHealthUI()
    {
        texthealth.text = health.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //  if(collision.gameObject.CompareTag("Cannon"))
        // {
        //     SceneManager.LoadScene(0);
        //  }
        if (collision.gameObject.CompareTag("Bomb"))
        {
            TakeDamge(1);
        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            float posX = transform.position.x;
            if (posX > 0)
            {
                rb.AddForce(Vector2.left * 100f);

            }
            else
            {
                rb.AddForce(Vector2.right * 100f);
            }



        }
        if (collision.gameObject.CompareTag("ROcket"))
        {
            Destroy(gameObject);
        }
    }
  
  
}
