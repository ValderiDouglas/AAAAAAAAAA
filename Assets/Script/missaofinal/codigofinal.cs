using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class codigofinal : MonoBehaviour
{
    public GameObject apresentacao;
    public GameObject quest1;
    public GameObject quest2;
    public GameObject quest3;
    public GameObject quest4;
    public GameObject quest5;
    public GameObject fim;
    public GameObject vitoria;
    public GameObject derrota;
    public GameObject capim;
    public GameObject personagem;
    public GameObject camerafinal;
    public GameObject barco;
    public GameObject Boto;
    public GameObject estrela;
    bool missaofim;
    bool colidiu;
    int gatilhoconversa;
    bool gatilhomissao;
    bool brek;
    public string cena;
    bool completou;
    void Start()
    {
        apresentacao.SetActive(false);
        quest1.SetActive(false);
        quest2.SetActive(false);
        quest3.SetActive(false);
        quest4.SetActive(false);
        quest5.SetActive(false);
        fim.SetActive(false);
        vitoria.SetActive(false);
        derrota.SetActive(false);
        capim.SetActive(false);
        barco.SetActive(false);
        Boto.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(missaocapim.diariocapivara && tutorial.diarioarara && missaomadeira.diarioonca) completou=true;
        
        if(completou) estrela.SetActive(true);
        else estrela.SetActive(false);
        
        if(colidiu){
            if(Input.GetKeyDown(KeyCode.E)&& !missaocapim.diariocapivara){
                StartCoroutine("Insert");
            }
            if(Input.GetKeyDown(KeyCode.E)&& !gatilhomissao && missaocapim.diariocapivara){
                gatilhoconversa++;
                if (gatilhoconversa>1){
                    gatilhoconversa=0;
                    gatilhomissao = true;
                }
                if(gatilhoconversa==1){
                    apresentacao.SetActive(true);
                }
                else{
                    apresentacao.SetActive(false);
                }
                
            }
            if (missaofim && !brek && botao.win>=8){
            fim.SetActive(true);
            brek=true;
            botao.win=0;
            StartCoroutine("final");

        }
        quests();
        }
        else{
            apresentacao.SetActive(false);
            quest1.SetActive(false);
            quest2.SetActive(false);
            quest3.SetActive(false);
            quest4.SetActive(false);
            quest5.SetActive(false);
            fim.SetActive(false);
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
        if( gatilhomissao && !brek && botao.win==0 && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)) ){
            quest1.SetActive(true);
            abremenu.gatilho=-1;
            desblock();
            botao.lose=false;
        }
        if (botao.lose){
            quest1.SetActive(false);
            quest2.SetActive(false);
            quest3.SetActive(false);
            quest4.SetActive(false);
            quest5.SetActive(false);
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
                quest3.SetActive(true);
                vitoria.SetActive(false);
                botao.win++;
            }
        }
        if(botao.win==5){
            quest3.SetActive(false);
            vitoria.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)){
                quest4.SetActive(true);
                vitoria.SetActive(false);
                botao.win++;
            }
        }
        if(botao.win==7){
            quest4.SetActive(false);
            fim.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)){
                fim.SetActive(false);
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
    IEnumerator Insert (){
        capim.SetActive(true);
        yield return new WaitForSeconds(3f);
        capim.SetActive(false);
    }
    IEnumerator final (){
        personagem.SetActive(false);
        fim.SetActive(false);
        barco.SetActive(true);
        camerafinal.SetActive(true);
        Boto.SetActive(true);
        yield return new WaitForSeconds(12f);
        SceneManager.LoadScene(cena);
        desblock();
    }
}
