using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin4FIssion : Coin1
{
    public GameObject coin1;
    public GameObject coin2;
    public GameObject timer;

    // Start is called before the first frame update
    

    // Update is called once per frame
    override protected  void die()
    {
        SpiltCoins();
        Destroy(this.gameObject);
    }

    void SpiltCoins()
    {
        coin1.transform.SetParent(null);
        coin2.transform.SetParent(null);
        coin1.SetActive(true);
        coin2.SetActive(true);
        timer.transform.SetParent(null);
        timer.SetActive(true);
    }
}
