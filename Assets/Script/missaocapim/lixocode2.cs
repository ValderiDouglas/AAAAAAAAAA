using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixocode2 : MonoBehaviour
{
    public Animator animcolher;  
    public GameObject pessoa;
    public static bool interativo;
    bool pegandolixo;
        void Update() {

        if(barralixo.interruptor){
            animcolher.SetInteger("colher",2);
            animcolher.SetInteger("Transition",0);
            parado();
        }
        if(interativo && missaocapim.gatilhomissao && barralixo.relogio)
        {  
            gameObject.SetActive(false);
            if (!pegandolixo){
                missaocapim.quantoslixos +=1;
                pegandolixo = true;
                barralixo.relogio=false;
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
