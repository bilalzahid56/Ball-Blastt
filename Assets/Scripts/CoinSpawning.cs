using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawning : MonoBehaviour
{
    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;
    public GameObject rocketBox;
    public GameObject multiBox;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RepeatingCoin1", 5f, 8f);
        InvokeRepeating("RepeatingCoin2", 7f, 10f);
        InvokeRepeating("RepeatingCoin3", 9f, 12f);
        InvokeRepeating("RepeatingCoin4", 13f, 19f);
        InvokeRepeating("RocketBoxDisplay", 10f, 10f);
        InvokeRepeating("MultiBoxDisplay", 14f, 15f);
    }

    // Update is called once per frame
    
    void RepeatingCoin1()
    {
        Instantiate(coin1, new Vector3(Random.Range(-7f, 7f), Random.Range(1.5f, 4.5f), 0), transform.rotation);
        
    }
    void RepeatingCoin2()
    {
        Instantiate(coin2, new Vector3(Random.Range(-7f, 7f), Random.Range(1.5f, 4.5f), 0), transform.rotation);
       
    }
    void RepeatingCoin3()
    {
        Instantiate(coin3, new Vector3(Random.Range(-7f, 7f), Random.Range(1.5f, 4.5f), 0), transform.rotation);
    }
    void RepeatingCoin4()
    {
        Instantiate(coin4, new Vector3(Random.Range(-7f, 7f), Random.Range(1.5f, 4.5f), 0), transform.rotation);
    }
    void RocketBoxDisplay()
    {
        Instantiate(rocketBox, new Vector3(Random.Range(-7f, 7f), Random.Range(1.5f, 4.5f), 0), transform.rotation);
    }
    void MultiBoxDisplay()
    {
        Instantiate(multiBox, new Vector3(Random.Range(-7f, 7f), Random.Range(1.5f, 4.5f), 0), transform.rotation);
    }
}    

