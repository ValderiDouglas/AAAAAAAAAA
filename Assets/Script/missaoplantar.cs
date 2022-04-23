using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missaoplantar : MonoBehaviour
{   
    bool gatilho;
    public static int quantos;
    public static bool gatilhomissao;
    bool quantidadecompleta;
    int gatilhoconversa;
    
    public GameObject quest1;
    public GameObject quest2;
    public GameObject vitoria;
    public GameObject derrota;
    public GameObject texto1;
    public GameObject iconemapa;
    // public GameObject texto2;

    bool brek;
    bool missaofim;
    public GameObject textofinal;
    public Text contador;
    void Update(){
        if(gatilhomissao) contador.text= ""+ quantos+ "/3";

        if(gatilho){
            if(Input.GetKeyDown(KeyCode.E) && !quantidadecompleta){
                gatilhomissao=true;
                gatilhoconversa++;
                
                contador.enabled=true;
                if (gatilhoconversa>1){
                    gatilhoconversa=0;
                }
                if(gatilhoconversa==1){
                    texto1.SetActive(true);
                }   
                // if(gatilhoconversa==2){
                //     texto2.SetActive(true);
                //     texto1.SetActive(false);
                // }
                else{
                    texto1.SetActive(false);
                }
            }
            if (quantidadecompleta && missaofim && !brek && botao.win>=4){
            contador.enabled=false;
            gatilhomissao=false;
            textofinal.SetActive(true);
            brek=true;
            botao.win=0;
            iconemapa.SetActive(false);
            
        }
            quests();
        }
        else{
            texto1.SetActive(false);
            // texto2.SetActive(false);
            textofinal.SetActive(false);
        }
        if(quantos>=3){
            quantidadecompleta=true;
        }
        // if (quantidadecompleta && missaofim && !brek && botao.win>=4){
        //     contador.enabled=false;
        //     gatilhomissao=false;
        //     textofinal.SetActive(true);
        // }
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
        public void quests(){
        if(quantidadecompleta && botao.win==0 && !brek && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)) ){
            quest1.SetActive(true);
            abremenu.gatilho=-1;
            desblock();
            botao.lose=false;
        }
        if (botao.lose){
            quest1.SetActive(false);
            quest2.SetActive(false);
            //quest3.SetActive(false);
            derrota.SetActive(true);
            botao.win=0;
        }
        else{
            derrota.SetActive(false);
        }
        if(botao.win==1 ){
            quest1.SetActive(false);
            vitoria.SetActive(true);
            
            if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0) ){
                quest2.SetActive(true);
                vitoria.SetActive(false);
                botao.win++;
            }
        }
        if(botao.win==3){
            quest2.SetActive(false);
            vitoria.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)){
                vitoria.SetActive(false);
                botao.win++;
                missaofim = true;
                block();
                abremenu.gatilho=0;
            }
        }
    }
    public void block(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void desblock(){
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
