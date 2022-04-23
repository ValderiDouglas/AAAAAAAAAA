using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudacode : MonoBehaviour
{       
    public Animator animcolher;
    public GameObject pessoa;
    public BoxCollider teste;
    bool plantando;
    bool pegourepolho;
        void Update() {
        
        if(barraplantar.interruptor){
            animcolher.SetInteger("colher",-1);
            animcolher.SetInteger("Transition",0);
            parado();

        }
        if(plantando && missaoplantar.gatilhomissao && barraplantar.relogio)
        {  
                missaoplantar.quantos +=1;
                barraplantar.relogio=false;
                animcolher.SetInteger("colher",0);
                andando();
                teste.enabled=false;
                
        }
    }
    void OnTriggerEnter(Collider hit)
    {
        
        if (hit.gameObject.tag == "Player" && missaoplantar.gatilhomissao)
        {   
            plantando = true;
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag== "Player"){
            plantando=false;
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
