using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class config : MonoBehaviour
{
    
    public GameObject configuracao;
    void Start(){
        configuracao.SetActive(false);
    }
    void Update()
    {
        if(bttConfig.gatilhoconfig) configapp();
    }

    public void configapp(){
        if(abremenu.gatilho==1){
            configuracao.SetActive(true);
        }   
        if(abremenu.gatilho==0){
            configuracao.SetActive(false);
            bttConfig.gatilhoconfig=false;
        }
    }
}
