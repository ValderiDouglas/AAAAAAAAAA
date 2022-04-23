using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movi : MonoBehaviour
{
    [SerializeField]
    float speed= 2f;
    CharacterController cc;

    void Awake()
    {
        cc= GetComponent<CharacterController>();
    }
    void Update()
    {
        Vector3 movementInput = Vector3.zero;
        if(Input.GetKey(KeyCode.W)){
            movementInput.z=-1;
        }
        else if(Input.GetKey(KeyCode.S)){
            movementInput.z=1;
        }
        if(Input.GetKey(KeyCode.D)){
            movementInput.x=-1;
        }
        else if(Input.GetKey(KeyCode.A)){
            movementInput.x=1;
        }

        Move(movementInput);
    }

    void Move(Vector3 direction){
        cc.SimpleMove(direction.normalized* speed);
    }

}
