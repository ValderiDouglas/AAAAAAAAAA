using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galeria : MonoBehaviour
{
    public GameObject galeria;
    void Update()
    {
        if(bttGaleria.gatilhogaleria) app();
    }

    public void app(){
        if(abremenu.gatilho==1){
            galeria.SetActive(true);
        }   
        if(abremenu.gatilho==0){
            galeria.SetActive(false);
            bttGaleria.gatilhogaleria=false;
            abremenu.uso=false;
        }
    }
}
