using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseLife : MonoBehaviour
{
    public int Life = 100;
    
    public void Loose(int lifeloose)//Metodo de perder vida
    {
        Life = Life - lifeloose;
        if (Life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
