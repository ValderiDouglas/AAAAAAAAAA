using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trocadetela : MonoBehaviour
{
    public static int gatilho;
public void Bttback(){
    gatilho--;
}
public void Bttnext(){
    gatilho++;
}
public void Update(){
    if(gatilho>2){
        gatilho=0;
    }
    if(gatilho<0){
        gatilho=2;
    }
}
}
