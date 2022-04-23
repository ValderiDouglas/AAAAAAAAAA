using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisaocamera : MonoBehaviour
{
    public Transform alvo;
    RaycastHit hit = new RaycastHit();
    public float mouseX = 0;
    public float mouseY = 0;

    public float distCam;

    public float ajusteCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //variaveis que representam as posições drente as tres dimenções 
        transform.RotateAround(alvo.position, transform.up, Input.GetAxis("Mouse X"));
        transform.RotateAround(alvo.position, transform.right, Input.GetAxis("Mouse Y"));

        // habilita a leitura de angulos 
        Vector3 rotacao = transform.eulerAngles;
        rotacao.z = 0;
        transform.eulerAngles = rotacao;
        // calcula a distancia entra a camera e o player 
        transform.position = alvo.position - transform.forward * distCam;
        // verifica se o objeto camera colidiu com o ambiente, se sim recalcula não permitindo que a camera atravesse o objeto
        if (Physics.Linecast(alvo.position, transform.position, out hit))
        {
            transform.position = hit.point + transform.forward * ajusteCamera;
        }
    }
}
