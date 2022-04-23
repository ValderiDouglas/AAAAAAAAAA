using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conversa : MonoBehaviour
{
    // Start is called before the first frame update
    int gatilhoconversa;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            gatilhoconversa++;
        }
        if (gatilhoconversa>2){
            gatilhoconversa=0;
        }
        if(gatilhoconversa==0){
            
        }   
        else{

        }
    }
}
