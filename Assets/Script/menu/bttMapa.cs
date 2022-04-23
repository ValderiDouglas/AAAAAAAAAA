using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bttMapa : MonoBehaviour
{
    public static bool gatilhomapa;
    public void Appmapa(){
        abremenu.uso=true;
        gatilhomapa=true;
        abremenu.gatilho=0;
    }
}
