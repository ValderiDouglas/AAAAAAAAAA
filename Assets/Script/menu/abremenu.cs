using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abremenu : MonoBehaviour
{    
    public Camera cameraterceira;
    public GameObject cameraprimeira;
    public Animator anim;
    public GameObject pessoa;
    public static int gatilho;
    public static bool cursor;
    public static bool telafoifirst;    
    public static bool uso;
    void Update()
    {
        /*if(telafoifirst){
                cameraprimeira.GetComponent<cameraprimeirapessoa>().enabled=true;
                pessoa.GetComponent<testemovimento>().enabled=true;
            }
            else{
                pessoa.GetComponent<Player>().enabled=true; 
                cameraterceira.GetComponent<controlecamera>().enabled=true;
            }
            */
        
        if(Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.Escape)){
            gatilho++;
            
            if(gatilho>1){
            gatilho=0;
            }
        }
        if(gatilho==1 && !uso){
            GetComponent<Canvas>().enabled=true;
            comandmenu();
            desblockmouse();
            }
        
        if(gatilho==0 && !uso){
            GetComponent<Canvas>().enabled=false;
            comandterceirapersona();
            blockmouse();
            cameraprimeira.SetActive(false);
            cameraterceira.enabled=true;
            pessoa.GetComponent<testemovimento>().enabled=false;
            }
        if(cameracelular.gatilhoapp){
            GetComponent<Canvas>().enabled=false;
            comandprimeirapersona();
            blockmouse();
            cameraprimeira.SetActive(true);
            cameraterceira.enabled=false;    
        }
        if(gatilho==0 && uso ){
            uso=false;
            cameracelular.gatilhoapp=false;   
        }
        if(gatilho==-1){
            cameraterceira.GetComponent<controlecamera>().enabled= false;
            pessoa.GetComponent<Player>().enabled=false;
        }
        if(gatilho==1 && uso){
            if(Input.GetKeyDown(KeyCode.Tab)){
                gatilho++;
            }
            GetComponent<Canvas>().enabled=false;
        }
        
    }
    public void comandprimeirapersona(){
        cameraprimeira.GetComponent<cameraprimeirapessoa>().enabled=true;
        pessoa.GetComponent<testemovimento>().enabled=true;
        anim.enabled=true;
    }
    public void comandterceirapersona(){
        cameraterceira.GetComponent<controlecamera>().enabled= true;
        pessoa.GetComponent<Player>().enabled=true;
        anim.enabled=true;
    }
    public void comandmenu(){
        cameraprimeira.GetComponent<cameraprimeirapessoa>().enabled=false;
        cameraterceira.GetComponent<controlecamera>().enabled=false;
        pessoa.GetComponent<Player>().enabled=false;
        pessoa.GetComponent<testemovimento>().enabled=false;
        anim.enabled=false;
    }
    public void blockmouse(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void desblockmouse(){
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

}
