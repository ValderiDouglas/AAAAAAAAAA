using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController controller;
    private Animator anim;

    public float speed;
    public float gravity;
    public float rotSpeed;

    public static bool corrida;
    private float rot;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        corrida=false;
    }

    // Update is called once per frame
    void Update()
    {

        Move();

    }
void Move()
    {
        // caso registre o input do shift esquerdo libera a condição de corrida ao player
        if(Input.GetKey(KeyCode.LeftShift)){
                corrida=true;
            }
        else{
            corrida=false;
        }
        // se controllador estiver ativo, então:
        if(controller.isGrounded)
        {
            // caso registre o input da tecla W com a condição de corrida irá complementar a velocidade do player, diferentemente se fosse uma movimentação comum
            if (Input.GetKey(KeyCode.W)&& corrida){
                moveDirection= Vector3.forward * speed * 2;
            }
            // caso registre o input da tecla W sem a condição de corrida, movimentará o player para a posição de forma positiva;
            if(Input.GetKey(KeyCode.W)&& !corrida)
            {
                moveDirection = Vector3.forward * speed;
            }
            // caso registre a pausa da tecla W, a variavel receberá 0 e para seu movimento;
            if(Input.GetKeyUp(KeyCode.W))
            {
                moveDirection = Vector3.zero;
            }
            // caso registre o input da tecla S movimentará o player para a posição de forma negativa;
            if(Input.GetKey(KeyCode.S))
            {
                moveDirection=(Vector3.forward * speed) * -1;
            }

            if(Input.GetKeyUp(KeyCode.S))
            {
                moveDirection= Vector3.zero;
            }
        }
        // caso registre teclas pre determinada "horizontal"(A, D) o objeto recebe valores para girarem sua rotação no eixo
        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);
        // aplica gravidade no player
        moveDirection.y -= gravity * Time.deltaTime;
        moveDirection = transform.TransformDirection(moveDirection);
        // transferem as alterações do codigo para o componente do player
        controller.Move(moveDirection * Time.deltaTime);

    }
}
