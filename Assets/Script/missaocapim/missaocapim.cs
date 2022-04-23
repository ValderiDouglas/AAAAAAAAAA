using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missaocapim : MonoBehaviour
{
    public GameObject missaoplanta;
    public GameObject telamissaocompleta;
    public GameObject missaoplanta1;
    public GameObject quest1;
    public GameObject quest2;
    public GameObject vitoria;
    public GameObject derrota;
    public GameObject iconemapa;
    public GameObject conjuntocapim;
    public Animator lago;

    bool interativocapim;
    public static bool gatilhomissao;
    bool quantidadecompleta;
    public static int quantosrepolhos;
    public static int quantoslixos;
    bool missaofim;
    bool brek;
    public Text textorepolho;
    public Text contadorlixo;
    public static bool diariocapivara;
    bool lagogatilho;
    int gatilhoconversa;


    void Start(){
        missaoplanta.SetActive(false);
        gatilhomissao=false;
        telamissaocompleta.SetActive(false);
        textorepolho.enabled=false;
        contadorlixo.enabled=false;
        missaoplanta1.SetActive(false);
        quest1.SetActive(false);
        quest2.SetActive(false);
        conjuntocapim.SetActive(false);
    }
    void Update() {
        if(gatilhomissao){ 
            textorepolho.text= ""+ quantosrepolhos+ "/5";
            contadorlixo.text= ""+ quantoslixos+ "/6";
            }
        
        if(quantoslixos>=6 && !lagogatilho){
            StartCoroutine("Insert");
            lagogatilho=true;
        }

        if(interativocapim){
        if(Input.GetKeyDown(KeyCode.E) && !quantidadecompleta)
        {
            gatilhoconversa++;
            textorepolho.enabled=true;
            contadorlixo.enabled=true;
            if (gatilhoconversa>2){
            gatilhoconversa=0;
            }
            if(gatilhoconversa==1){
            missaoplanta.SetActive(true);
            }   
            if(gatilhoconversa==2){
            missaoplanta1.SetActive(true);
            missaoplanta.SetActive(false);
            }
            else{
                missaoplanta1.SetActive(false);
            }
            gatilhomissao = true;
            
        }
        if (quantosrepolhos >= 5 && quantoslixos >= 6){
            quantidadecompleta= true;
        }


        if (quantidadecompleta && missaofim && !brek && botao.win>=4){
            telamissaocompleta.SetActive(true);
            brek=true;
            diariocapivara=true;
            textorepolho.enabled= false;
            contadorlixo.enabled= false;
            iconemapa.SetActive(false);
            botao.win=0;
        }
        quests();

        }
        else{
            quest1.SetActive(false);
            quest2.SetActive(false);
            vitoria.SetActive(false);
            derrota.SetActive(false);
            missaoplanta.SetActive(false);
            missaoplanta1.SetActive(false);
            telamissaocompleta.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider hit){
        if (hit.gameObject.tag == "Player")
        {
            interativocapim = true;
        }

    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            interativocapim = false;
            gatilhoconversa=0;
        }
    }

    void quests(){
        if(quantidadecompleta && !brek && botao.win==0 && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)) ){
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
        //if(botao.win==2 && interativocapim){
          //  quest1.SetActive(false);
            //quest2.SetActive(false);
            //quest3.SetActive(true);
        //}
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
        yield return new WaitForSeconds(.1f);
        lago.SetTrigger("gatilho");
        yield return new WaitForSeconds(5f);
        conjuntocapim.SetActive(true);
    }
}


//A dieta deste animal é composta principalmente por gramíneas, sendo assim um animal herbívoro
//A capivara se alimenta principalmente de gramíneas, então pode ser considerado um animal: