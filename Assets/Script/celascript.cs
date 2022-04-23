using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celascript : MonoBehaviour
{
    bool interagiu;
    public static bool libertada;
    public Animator obj;
    public Animator anim;
    public GameObject onca;
    void Update()
    {
        if(interagiu){
            if(Input.GetKeyDown(KeyCode.E)&& missaomadeira.gatilhomissao){
                libertada=true;
                obj.SetTrigger("gatilho");
                StartCoroutine("Insert");
            }
        }
    }
    void OnTriggerEnter(Collider hit){
        if(hit.gameObject.tag== "Player"){
            interagiu=true;
        }
    }
    void OnTriggerExit(Collider hit){
        if(hit.gameObject.tag== "Player"){
            interagiu=false;
        }
    }

    IEnumerator Insert (){
        yield return new WaitForSeconds(4.6f);
        anim.enabled=true;
        yield return new WaitForSeconds(10);
        onca.SetActive(false);
    }
}
