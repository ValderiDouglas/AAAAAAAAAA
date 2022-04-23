using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class diario : MonoBehaviour
{
    // public Text titulo;
    // public Text nome;
    // public GameObject sombrapavirava;
    // public Text textocapivara;
    // Start is called before the first frame update
    void Start()
    {
        //teladiario.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(bttDiario.gatilhodiario){
            Diarioapp();
        }
    }
    public void Diarioapp(){
        
        if(abremenu.gatilho==1){
            //teladiario.SetActive(true);
        } 
        if(abremenu.gatilho==0){
            bttDiario.gatilhodiario=false;
            //teladiario.SetActive(false);
            abremenu.uso=false;
        }

        // if(missaocapim.diariocapivara){
        //     sombrapavirava.SetActive(false);
            
        //     titulo.text="Animal desbloqueado";
        //     nome.text="Capivara";
        //     textocapivara.text= "A Capivara é um animal pertencente a classe dos Mamíferos Roedores, assim como as pacas, preás e porquinhos da Índia."+ "\n\n"+ "Ela se encontra em todos os países da América do Sul, principalmente em habitats associados a ??????????????."+"\n\n"+" A dieta deste animal é composta principalmente por gramíneas, sendo assim um animal herbívoro.";
        // }
    }
}
