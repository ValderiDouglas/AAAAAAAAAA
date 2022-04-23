using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repolhocode5 : MonoBehaviour
{   
    public Animator animcolher;
    public GameObject pessoa;
    bool interativo;
    bool pegourepolho;
    void Update() {
        if(barrascript.interruptor){
            animcolher.SetInteger("colher",1);
            animcolher.SetInteger("Transition",0);
            parado();
        }
        if(interativo && missaocapim.gatilhomissao && barrascript.relogio)
        {  
            gameObject.SetActive(false);
            if (!pegourepolho){
                missaocapim.quantosrepolhos +=1;
                pegourepolho = true;
                barrascript.relogio=false;
                animcolher.SetInteger("colher",0);
                andando();
            }
        }
    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player" && missaocapim.gatilhomissao)
        {   
            interativo = true;
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag== "Player"){
            interativo=false;
        }
    }
    public void parado(){
        pessoa.GetComponent<Player>().speed=0;
        pessoa.GetComponent<auxmain>().enabled=false;
    }
    public void andando(){
        pessoa.GetComponent<Player>().speed=3;
        pessoa.GetComponent<auxmain>().enabled=true;
    }
}
