using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trocaskate : MonoBehaviour
{    public Transform pointmain;
    public Transform pointskate;
    public GameObject main;
    public GameObject skate;
    int gatilhoskate= 0;
    // Start is called before the first frame update
    void Start()
    {
        skate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.F)){
            gatilhoskate++;
        }
        if (gatilhoskate>1){
            gatilhoskate=0;
        }
        if(gatilhoskate ==1 && Input.GetKeyDown(KeyCode.F)){
            skate.SetActive(true);
            skate.transform.position = pointmain.position;
            skate.transform.rotation = pointmain.rotation;
            main.SetActive(false); 
            
            
        }  
        if(gatilhoskate==0 && Input.GetKeyDown(KeyCode.F)){
            main.SetActive(true);
            main.transform.position = pointskate.position;
            main.transform.rotation = pointskate.rotation;
            skate.SetActive(false);
        }
    }        
}
