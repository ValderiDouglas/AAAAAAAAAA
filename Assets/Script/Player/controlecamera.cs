using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlecamera : MonoBehaviour
{
    public bool lockCursor;

    RaycastHit hit = new RaycastHit();
    public float mouseSensivity = 10;
    public Transform target;
    public float distanceFromTarget = 2;
    public Vector2 pitchMinMax = new Vector2(-40, 85);

 
    public float RotationSmoothTime = .12f;
    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    float yam;
    float pitch;
    public float ajusteCamera;

    void Start()
    {  //se cursor estiver ativado é desativado
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    void LateUpdate()
    {
        //variaveis que representam as posições drente as tres dimenções 
        yam += Input.GetAxis("Mouse X") * mouseSensivity;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensivity;
        // limita o angulo maximo de visão que a camera 
        pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);
        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yam), ref rotationSmoothVelocity, RotationSmoothTime);
        transform.eulerAngles = currentRotation;
        // calcula a distancia entra a camera e o player 
        transform.position = target.position - transform.forward * distanceFromTarget;
        // verifica se o objeto camera colidiu com o ambiente, se sim recalcula não permitindo que a camera atravesse o objeto
        if (Physics.Linecast(target.position, transform.position, out hit))
        {
            transform.position = hit.point + transform.forward * ajusteCamera;
        }
        
    }
}