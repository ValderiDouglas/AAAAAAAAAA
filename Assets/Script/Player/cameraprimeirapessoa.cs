using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraprimeirapessoa : MonoBehaviour
{
    public Transform corpo;
    public Transform cabeca;
    public float sensibilidade=20;

    float rotacaoX=0;
    float rotacaoY=0;

    float angulomaximoY= 85;
    float angulominimoY= -40;
    //float angulomaximoX= 90;
    //float angulominimoX= -90;
    void Start(){


    }
    private void LateUpdate(){
        transform.position= cabeca.position;
    }

    void Update(){
        float verticalDelta = Input.GetAxisRaw("Mouse Y")* sensibilidade;
        float horizontalDelta= Input.GetAxisRaw("Mouse X")* sensibilidade;

        rotacaoX += horizontalDelta * Time.deltaTime;
        rotacaoY += verticalDelta * Time.deltaTime;

        rotacaoY= Mathf.Clamp(rotacaoY, angulominimoY,angulomaximoY);
        //rotacaoX= Mathf.Clamp(rotacaoX, angulominimoX,angulomaximoX);


        
        corpo.localEulerAngles = new Vector3(0, rotacaoX, 0);

        transform.localEulerAngles= new Vector3(-rotacaoY, rotacaoX,0);
    }
}
