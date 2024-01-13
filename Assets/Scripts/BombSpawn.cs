using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawn : MonoBehaviour
{
    public GameObject bomb;
    public GameObject bombArea;
   
   

    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine("bombRepeat");
        InvokeRepeating("Bomb", 0.04f, 0.04f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

   
    void Bomb()
    {
        Instantiate(bomb, bombArea.transform.position, bombArea.transform.rotation);
       
    }
}
