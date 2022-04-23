using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testemovimento : MonoBehaviour
{
    CharacterController controle;
    Vector3 anguloY;
    Vector3 anguloX;
    private Vector3 moveDirection;

    float anguloYvelocidade= 5f;
    float anguloXvelocidade= 5f;

    int gravity=200;
    void Start()
    {
        controle = GetComponent<CharacterController>();
    }

    void Update()
    {
        float anguloYInput= Input.GetAxisRaw("Vertical");
        float anguloXInput= Input.GetAxisRaw("Horizontal");

        anguloY= anguloYInput* anguloYvelocidade* transform.forward;
        anguloX= anguloXInput * anguloXvelocidade * transform.right;

        Vector3 finalvelocidade= anguloY+anguloX;
        controle.Move(finalvelocidade*Time.deltaTime);

        moveDirection.y -= gravity * Time.deltaTime;

        moveDirection = transform.TransformDirection(moveDirection);

        controle.Move(moveDirection * Time.deltaTime);
    }
}
