using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barraplantar : MonoBehaviour
{   
    public static bool relogio;
    float timer=1.5f;
    float segundos;
    public static bool interruptor;
    public GameObject barra;
    public Image notificacao;

    public GameObject sementes;
    public GameObject regador;
    public BoxCollider box;
    
    bool coletado;
    bool gatilho;
    void Start(){
        gatilho=false;
        regador.SetActive(false);
        barra.SetActive(false);
        sementes.SetActive(false);
    }
    void Update()
    {   
        if(gatilho && !coletado){
            barra.SetActive(true);
        }
        if(Input.GetKey(KeyCode.E) && gatilho){
        interruptor= true;
        notificacao.fillAmount -= Time.deltaTime * 0.081f;
        if(interruptor){
            segundos += 1/timer*Time.deltaTime;
            while(segundos >=8.3){
                notificacao.fillAmount=1;
                relogio = true;
                box.enabled=false;
                gatilho=false;
                interruptor = false;
                barra.SetActive(false);
                coletado=true;
                break;
            }
            if(segundos>5.3){
                sementes.SetActive(true);
                regador.SetActive(true);
            }
            if(segundos>8.3){
                regador.SetActive(false);
            }
        }
        }
        
    }
    void OnTriggerEnter(Collider hit){
        if (hit.gameObject.tag == "Player"&& missaoplantar.gatilhomissao)
        {
            gatilho=true;
            
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            gatilho=false;

            barra.SetActive(false);
            
        }
    }
}
