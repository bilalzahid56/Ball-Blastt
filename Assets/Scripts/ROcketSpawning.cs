using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROcketSpawning : MonoBehaviour
{
    public GameObject rocket;
    public GameObject bombArea;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(Rocketshow());

    }

    // Update is called once per frame
 

    IEnumerator Rocketshow()
        {
        Instantiate(rocket, bombArea.transform.position, bombArea.transform.rotation);
        yield return new WaitForSeconds(1.3f);
        Instantiate(rocket, bombArea.transform.position, bombArea.transform.rotation);
        yield return new WaitForSeconds(1.3f);
        Instantiate(rocket, bombArea.transform.position, bombArea.transform.rotation);
    }
}
