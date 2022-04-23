using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
public class cameracelular : MonoBehaviour
{
    private int alter;
    private bool gatilhofotografia;
    public GameObject telacamera;
    public Camera camprimeira;
    public Camera camterceira;
    string foto;
    public static bool fotografado;
    public static bool gatilhoapp;

    void Start(){
        gatilhoapp=false;
        foto = Application.dataPath + "/capturascamera/";
        if(!Directory.Exists(foto))
        {
            Directory.CreateDirectory(foto);
        }
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Mouse0)&& gatilhoapp){
            string nomeimagem = foto + DateTime.Now.Ticks.ToString() +".png";
            UnityEngine.ScreenCapture.CaptureScreenshot(nomeimagem);
            //Application.CaptureScreenshot(nomeimagem);
            fotografado=true;
        }
        if(!gatilhoapp){
            telacamera.SetActive(false);
        }
    }
    
    public void Appcamera(){
        abremenu.uso=true;
        gatilhoapp=true;
        telacamera.SetActive(true);
    }
}