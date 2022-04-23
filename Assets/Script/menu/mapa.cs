using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapa : MonoBehaviour
{   
    public GameObject objcamera;
    public Camera cameramapa;
    private Canvas objeto;
    public GameObject player;
    public GameObject missao;
    // Start is called before the first frame update
    void Start()
    {
        objeto=GetComponent<Canvas>();
        objcamera.SetActive(false);
        cameramapa.depth= -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(bttMapa.gatilhomapa) {
        mapas();
        }
    }
    void mapas(){
        if(abremenu.gatilho==0){
            player.SetActive(true);
            objcamera.SetActive(true);
            objeto.enabled=true;
            cameramapa.depth=10;
        }   
        if(abremenu.gatilho==1){
            player.SetActive(false);
            objcamera.SetActive(false);
            objeto.enabled=false;
            cameramapa.depth=-1;
            bttMapa.gatilhomapa=false;
        }
        
    }
}


