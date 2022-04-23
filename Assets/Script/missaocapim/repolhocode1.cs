using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repolhocode1 : MonoBehaviour
{   
    public Animator animcolher;
    public GameObject pessoa;
    bool pegandorepolho;
    bool pegourepolho;
        void Update() {
        
        if(barrascript.interruptor){
            animcolher.SetInteger("colher",1);
            animcolher.SetInteger("Transition",0);
            parado();

        }
        if(pegandorepolho && missaocapim.gatilhomissao && barrascript.relogio)
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
            pegandorepolho = true;
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag== "Player"){
            pegandorepolho=false;
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
