using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missaomadeira : MonoBehaviour
{
    public GameObject tela;
    public GameObject tela2;
    public static bool gatilhomissao;
    public static bool diarioonca;
    bool interativo;
    int conversa=0;
    public GameObject quest1;
    public GameObject quest2;
    public GameObject vitoria;
    public GameObject derrota;
    public GameObject telacompleta;
    public GameObject estrela;
    bool missaofim;
    bool brek;
    public GameObject seta;
    void Start()
    {
        interativo=false;
        tela.SetActive(false);
        tela2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (interativo){
            if(Input.GetKeyDown(KeyCode.E)&& !celascript.libertada){
                conversa++;
                seta.SetActive(false);
                gatilhomissao = true;
                if(conversa>2){
                    conversa=0;
                }
                if(conversa==1){
                    tela.SetActive(true);
                }
                if(conversa==2){
                    tela.SetActive(false);
                    tela2.SetActive(true);
                } 
                if( conversa==0){
                    tela.SetActive(false);
                    tela2.SetActive(false);
                }
            }
            quests();
            if(missaofim && !brek){
            brek=true;
            telacompleta.SetActive(true);
            botao.win=0;
            diarioonca=true;
            estrela.SetActive(false);
            }
        }
        else{
            tela.SetActive(false);
            tela2.SetActive(false);
            telacompleta.SetActive(false);
        }
        
        
    }

    void OnTriggerEnter(Collider hit){
        if(hit.gameObject.tag== "Player"){
            interativo= true;
        }
    }
    void OnTriggerExit(Collider hit){
        if(hit.gameObject.tag== "Player"){
            interativo=false;
            conversa=0;
        }
    }
    
    public void desblock(){
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    public void block(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void quests(){
        if(celascript.libertada && !brek && botao.win==0 && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)) ){
            quest1.SetActive(true);
            abremenu.gatilho=-1;
            desblock();
            botao.lose=false;
        }
        if (botao.lose){
            quest1.SetActive(false);
            quest2.SetActive(false);
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
}
