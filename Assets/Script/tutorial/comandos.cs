using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandos : MonoBehaviour
{   
    public GameObject cinza;
    public GameObject Passo1;
    public GameObject Passo11;
    public GameObject Passo2;
    void Start()
    {   
        Passo1.SetActive(false);
        Passo2.SetActive(false);
        StartCoroutine("Rotina");
    }
    void Update()
    {
        
    }

    IEnumerator Rotina (){
        cinza.SetActive(true);
        Passo1.SetActive(true);
        Passo11.SetActive(true);
        yield return new WaitForSeconds(7f);
        Passo1.SetActive(false);
        Passo11.SetActive(false);
        Passo2.SetActive(true);
        yield return new WaitForSeconds(7f);
        Passo2.SetActive(false);
        cinza.SetActive(false);
    }
}
