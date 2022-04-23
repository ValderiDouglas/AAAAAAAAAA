using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botao : MonoBehaviour
{
    public static int win;
    public static bool lose;
    public void acertou(){
        win++;
    }
    public void Errou(){
        lose= true;
    }
}
