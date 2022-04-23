using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auxmain : MonoBehaviour
{
    public Animator personagem;
    void Start()     
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Dansa();
    }   

    void Dansa(){
        if(Input.GetKeyDown(KeyCode.Space))
        {
            personagem.SetTrigger("danca");    

        }
    }
    void Move()
    {
        if(Input.GetKey(KeyCode.W)&& Player.corrida){
            personagem.SetInteger("Transition",2);
        }
        if(Input.GetKey(KeyCode.W)&& !Player.corrida)
            {
                personagem.SetInteger("Transition", 1);
            }
        if(Input.GetKeyUp(KeyCode.W))
            {
                personagem.SetInteger("Transition", 0);
            }
        if(Input.GetKey(KeyCode.S))
            {
                personagem.SetInteger("Transition",-1);
            }

        if(Input.GetKeyUp(KeyCode.S))
            {
                personagem.SetInteger("Transition",0);
            }
                
    }
}