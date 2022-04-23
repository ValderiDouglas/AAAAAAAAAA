using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portas : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator portaesqueda;
    void OnTriggerEnter(Collider hit)
    {
        
          if(hit.gameObject.tag == "Player")
        {
            portaesqueda.SetTrigger("open");
        }
    }
}

