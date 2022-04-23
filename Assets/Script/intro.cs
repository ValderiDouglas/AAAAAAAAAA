using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ella;
    public GameObject cameraintro;
    public GameObject notificacao;
    public GameObject bonecaestatica;

    void Start()
    {
        ella.SetActive(false);
        notificacao.SetActive(false);
        StartCoroutine("introvideo");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator introvideo (){
        cameraintro.SetActive(true);
        yield return new WaitForSeconds(33.3f);
        bonecaestatica.SetActive(false);
        cameraintro.SetActive(false);
        ella.SetActive(true);
        yield return new WaitForSeconds(1f);
        notificacao.SetActive(true);
    }
}
