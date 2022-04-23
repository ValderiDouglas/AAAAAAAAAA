using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portaselevador : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator portaesqueda;
    bool botao;
    void Start(){
        botao = false;
    }
    void Update() {
        if(Input.GetKeyDown(KeyCode.E) && botao){
            portaesqueda.SetTrigger("open");
        }
    }
    void OnTriggerEnter(Collider hit)
    {        
          if(hit.gameObject.tag == "Player")
        {
           botao= true;
        }
    }

     void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            botao=false;
        }
    }
}

