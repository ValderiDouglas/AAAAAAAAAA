using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxarara : MonoBehaviour
{
    bool interativo;
    public GameObject gif;
    public GameObject ararareserva;
    
    void Start()
    {
        gif.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if(tutorial.colidiu)gif.SetActive(true);
        if(interativo){
            gif.SetActive(false);
            ararareserva.SetActive(true);
            tutorial.arara=true;
        }
    }
    void OnTriggerEnter(Collider hit){
        if(hit.gameObject.tag=="Player" || hit.gameObject.tag=="skate"){
            interativo=true;
        }
    }
    void OnTriggerExit(Collider hit){
        if(hit.gameObject.tag=="Player" || hit.gameObject.tag=="skate"){
            interativo=false;
        }
    }
}
