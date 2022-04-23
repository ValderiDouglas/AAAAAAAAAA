using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class arara : MonoBehaviour
{       
    public GameObject ararasombra;
    public Text titulo;
    public Text nome;
    public Text texto;
    void Start()
    {
        
    }

    void Update()
    {
         
    }
    void aplicacao(){
    if(missaocapim.diariocapivara){
            ararasombra.SetActive(false);
            titulo.text="Animal desbloqueado";
            nome.text="Capivara";
            texto.text= "A Capivara é um animal pertencente a classe dos Mamíferos Roedores, assim como as pacas, preás e porquinhos da Índia."+ "\n\n"+ "Ela se encontra em todos os países da América do Sul, principalmente em habitats associados a ??????????????."+"\n\n"+" A dieta deste animal é composta principalmente por gramíneas, sendo assim um animal herbívoro.";
        }
    }

}
