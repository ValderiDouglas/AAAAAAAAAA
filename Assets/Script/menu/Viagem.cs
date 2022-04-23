using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viagem : MonoBehaviour
{
    public GameObject viagem;
    void Update()
    {
        if(bttViagem.gatilhoviagem)app();
    }

    public void app(){
        if(abremenu.gatilho==1){
            viagem.SetActive(true);
        }   
        if(abremenu.gatilho==0){
            viagem.SetActive(false);
            bttViagem.gatilhoviagem=false;
        }
    }
}
