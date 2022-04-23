using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carroselgaleria : MonoBehaviour
{
    public GameObject foto1;
    public GameObject foto2;
    public GameObject botaonext;
    public GameObject botaoback;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(missaomadeira.gatilhomissao && cameracelular.fotografado){
            if(bttGaleria.gatilhogaleria){
                botaonext.SetActive(true);
                botaoback.SetActive(true);
                if(trocagaleria.gatilho== 0){
                    foto1.SetActive(true);
                }   
                else foto1.SetActive(false);
                if(trocagaleria.gatilho== 1){
                    foto2.SetActive(true);
                }  
                else foto2.SetActive(false);
            }
            else {foto1.SetActive(false);
            foto2.SetActive(false);
            }
    	}
    }
}
