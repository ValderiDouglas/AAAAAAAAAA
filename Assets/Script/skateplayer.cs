using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skateplayer : MonoBehaviour
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
        if(Input.GetKey(KeyCode.LeftShift)){
                corrida=true;
            }
        else{
            corrida=false;
        }
        if(controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W)&& corrida){
                moveDirection= Vector3.forward * speed * 5 ;
                anim.SetInteger("Transition",2);
            }
            if(Input.GetKey(KeyCode.W)&& !corrida)
            {
                moveDirection = Vector3.forward * speed * 3;
                anim.SetInteger("Transition",1);
            }

            if(Input.GetKeyUp(KeyCode.W))
            {
                moveDirection = Vector3.zero;
                anim.SetInteger("Transition",0);
            }
        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDirection.y -= gravity * Time.deltaTime;

        moveDirection = transform.TransformDirection(moveDirection);

        controller.Move(moveDirection * Time.deltaTime);

    }
}
