using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class carrossel : MonoBehaviour
{   
    public GameObject capivara;
    public GameObject arara;
    public GameObject onca;
    public GameObject telacapivara;
    public GameObject telaarara;
    public GameObject telaonca;
    public GameObject ararasombra;
    public GameObject sombrapavirava;
    public GameObject oncasombra;
    public Text tituloarara;
    public Text titulocapivara;
    public Text tituloonca;
    public Text nomearara;
    public Text nomecapivara;
    public Text nomeonca;
    public Text textoarara;
    public Text textocapivara;
    public Text textoonca;
    public void Update(){
        if(Input.GetKeyDown(KeyCode.F8)){
            missaocapim.diariocapivara=true;
        }
        // else missaocapim.diariocapivara=false;
        if(Input.GetKeyDown(KeyCode.F7)){
            tutorial.diarioarara=true;
        }
        // else tutorial.diarioarara=false;
        if(Input.GetKeyDown(KeyCode.F6)){
            missaomadeira.diarioonca=true;
        }
        // else missaomadeira.diarioonca=false;
        if(bttDiario.gatilhodiario){
            if(trocadetela.gatilho== 0){
                Capivara();
            }   
            else capivara.SetActive(false);
            if(trocadetela.gatilho== 1){
                Arara();
            }  
            else arara.SetActive(false);
            if(trocadetela.gatilho==2){
                Onca();
            }
            else  onca.SetActive(false);
        }   
        else{
            breack();
        }
    }   
    public void Capivara(){
        capivara.SetActive(true);
        if(missaocapim.diariocapivara){
            sombrapavirava.SetActive(false);
            titulocapivara.text="Animal desbloqueado";
            nomecapivara.text="Capivara";
            textocapivara.text= "A Capivara é um animal pertencente a classe dos Mamíferos Roedores, assim como as pacas, preás e porquinhos da Índia."+ "\n\n"+ "Ela se encontra em todos os países da América do Sul, essencialmente em habitats aquáticos."+"\n\n"+" A dieta deste animal é composta principalmente por gramíneas, sendo assim um animal herbívoro.";
        }
    }
    public void Arara(){
        arara.SetActive(true);
        if(tutorial.diarioarara){
            ararasombra.SetActive(false);
            tituloarara.text="Animal desbloqueado";
            nomearara.text="Arara vermelha";
            textoarara.text= "A arara é uma ave que apresenta diferentes colorações vermelhas, azuis e verdes, possuem bicos grossos e curvos que auxiliam em sua alimentação de Castanhas e frutas."+"\n\n"+"Elas habitam as florestas tropicais, como Amazônica, Mata Atlântica e Pantanal. Vivendo em bandos até desenvolverem relacionamentos monogâmicos, morando com seu parceiro dentro de troncos e barrancos até o fim da vida.";
        }
    }
    public void Onca(){
        onca.SetActive(true);
        if(missaomadeira.diarioonca){
            oncasombra.SetActive(false);
            tituloonca.text="Animal desbloqueado";
            nomeonca.text="Onça-Pintada";
            textoonca.text= "A onça-pintada é o maior felino das Américas. Elas são estritamente carnívoras, alimentando-se apenas de carne."+"\n\n"+" São animais com hábitos crepusculares e noturnos, são mais ativas ao anoitecer e amanhecer, além disso possuem uma coloração amarelo-dourada e pintas nas cabeças, patas e pescoço. No resto do corpo, possui rosetas com pintas no interior, conferindo um alto grau de camuflagem quando está no interior da mata.";
        }
    }

    public void breack(){
        arara.SetActive(false);
        capivara.SetActive(false);
        onca.SetActive(false);
    }
}
