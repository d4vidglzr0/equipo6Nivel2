using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int Life = 100;
    public int Daño = 20;
    public void LooseLife(int lifeloose)//Metodo de perder vida
    {
        Life = Life - lifeloose;
        if (Life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
