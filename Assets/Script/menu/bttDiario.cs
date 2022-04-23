using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bttDiario : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fed;
    public static bool gatilhodiario;
    public void Start(){
        fed.SetActive(false);
    }
    public void Appdiario(){
        abremenu.uso=true;
        gatilhodiario=true;
        fed.SetActive(true);
        //abremenu.gatilho=0;
    }
    public void Update(){
        if(abremenu.gatilho==0){
            fed.SetActive(false);
        }
    }
}
