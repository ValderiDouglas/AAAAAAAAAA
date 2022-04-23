using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iconemissaorepolho : MonoBehaviour
{
    public GameObject setamissaorepolho;
    bool gatilho;
    void Start(){
        gatilho=false;
        setamissaorepolho.SetActive(true);
    }
    void Update() {
        if(Input.GetKeyDown(KeyCode.E)&& gatilho)
        {  
            setamissaorepolho.SetActive(false);
        }
    }       

     void OnTriggerEnter(Collider hit){
        if (hit.gameObject.tag == "Player")
        {
            gatilho=true;
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            gatilho=false;
        }
    }
}
