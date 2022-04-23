using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trocadecena : MonoBehaviour
{
    public string cena;
    public void inicio(){
        SceneManager.LoadScene(cena);
        abremenu.gatilho=0;
    }
    public void sair(){
        Application.Quit();
    }
}
