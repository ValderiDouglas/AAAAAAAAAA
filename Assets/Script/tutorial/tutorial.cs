using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{   
    public GameObject seta;
    public static bool colidiu;
    public GameObject objmenu;
    public GameObject textoinicio;
    public GameObject textomeio;
    public GameObject textofinal;
    public GameObject objarara;
    public GameObject objeararaskate;
    public GameObject ararabot;
    public GameObject quest1;
    public GameObject quest2;
    public GameObject derrota;
    public GameObject vitoria;
    public GameObject inicioquestoes;
    public static bool diarioarara;
    // bool breaak;
    bool missaofim;
    // bool gatilhomissao;
    int gatilhoconversa;
    public static bool arara;
    void Start()
    {   
        objeararaskate.SetActive(false);
        objarara.SetActive(false);
        // arara=false;
        objmenu.SetActive(true);
    }
    void Update()
    {
        if(colidiu){
            if(Input.GetKeyDown(KeyCode.E)&& !arara && !missaofim){
                // gatilhomissao=true;
                gatilhoconversa++;
                if (gatilhoconversa>2){
                    gatilhoconversa=0;
                }
                if(gatilhoconversa==1){
                    textoinicio.SetActive(true);
                    seta.SetActive(false);
                    
                }
                if(gatilhoconversa==2){
                    textomeio.SetActive(true);
                    textoinicio.SetActive(false);
                    objeararaskate.SetActive(true);
                    objarara.SetActive(true);
                    ararabot.SetActive(false);
                }
                else{
                    textomeio.SetActive(false);
                }
                
            }
            // if(Input.GetKeyDown(KeyCode.E)&& arara && !missaofim){
                
            // }
            if(arara && missaofim){
                textofinal.SetActive(true);
                arara=false;
                seta.SetActive(false);
                botao.win=0;
                diarioarara=true;
            }     
            quests();   
        }
        else{
            textomeio.SetActive(false);
            textoinicio.SetActive(false);
            textofinal.SetActive(false);
        }
        if(arara){
            objeararaskate.SetActive(false);
            objarara.SetActive(false);
            seta.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider hit){
        if(hit.gameObject.tag=="Player")
        {
            colidiu=true;
        }
    }
    void OnTriggerExit(Collider hit){
        if(hit.gameObject.tag=="Player" || (hit.gameObject.tag=="skate"))
        {
            colidiu=false;
            gatilhoconversa=0;
        }
    }
    public void quests(){
        if(arara && botao.win==0 && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)) ){
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
    public void block(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void desblock(){
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
