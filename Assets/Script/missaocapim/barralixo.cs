using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barralixo : MonoBehaviour
{   
    public static bool relogio;
    float timer=1.5f;
    float segundos;
    public static bool interruptor;
    public GameObject barra;
    public Image notificacao;
    bool gatilho;
    void Start(){
        gatilho=false;
        barra.SetActive(false);
    }
    void Update()
    {   
        if(Input.GetKey(KeyCode.E) && gatilho){
            interruptor= true;
            notificacao.fillAmount -= Time.deltaTime * 0.33f;
            if(interruptor){
                segundos += 1/timer*Time.deltaTime;
                while(segundos >=2){
                    notificacao.fillAmount=1;
                    relogio = true;
                    interruptor = false;
                    barra.SetActive(false);
                    break;
                }
            }
        }
    }
    void OnTriggerEnter(Collider hit){
        if (hit.gameObject.tag == "Player"&& missaocapim.gatilhomissao)
        {
            gatilho=true;
            barra.SetActive(true);
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
