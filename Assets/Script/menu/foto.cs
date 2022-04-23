using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class foto : MonoBehaviour
{

    /*private string gatilhofoto;
    public Camera camprimeira;
    public Camera camterceira;
    public GameObject telacamera;
    public GameObject iconemapa; 
    public GameObject iconediario;

    public static bool gatilhofotografia;
    int alter=-1;
    
    void Start()
    {
    camprimeira.enabled=false;
     gatilhofoto = Application.dataPath + "/capturascamera/";
     if(!Directory.Exists(gatilhofoto))
     {
        Directory.CreateDirectory(gatilhofoto);
     }   
    }

    void Update()
    {
        //Fotografar();
        if(menu.gatilhoapp){
            GetComponent<Player>().enabled=false;
            GetComponent<testemovimento>().enabled=true;
        }
    }

    /*public void Fotografar(){
        if(Input.GetKeyDown(KeyCode.C)){

            alter++;
            
            
            if (alter>1){
                alter=0;
                
            }
            if(alter==0){
            gatilhofotografia= true;
            camprimeira.GetComponent<cameraprimeirapessoa>().enabled=true;
            camterceira.GetComponent<controlecamera>().enabled=false;
            telacamera.SetActive(true);
            camprimeira.enabled=true;
            camterceira.enabled=false;
            iconemapa.SetActive(false);
            iconediario.SetActive(false);    
            GetComponent<Player>().enabled=false;
            GetComponent<testemovimento>().enabled=true;        
            }
            if(alter==1){
            camprimeira.GetComponent<cameraprimeirapessoa>().enabled=false;
            camterceira.GetComponent<controlecamera>().enabled=true;
            gatilhofotografia=false;
            telacamera.SetActive(false);
            camprimeira.enabled=false;
            camterceira.enabled=true;
            iconemapa.SetActive(true);
            iconediario.SetActive(true);
            GetComponent<Player>().enabled=true;
            GetComponent<testemovimento>().enabled=false;
            }
        }
        if(Input.GetKeyDown(KeyCode.Mouse0)&& gatilhofotografia && !abremenu.cursor){
            camprimeira.fieldOfView= 20;
            string nomeimagem = gatilhofoto + DateTime.Now.Ticks.ToString() +".png";
            UnityEngine.ScreenCapture.CaptureScreenshot(nomeimagem);
            //Application.CaptureScreenshot(nomeimagem);
        }
        else{
            camprimeira.fieldOfView=60;
        }
    }*/
}

