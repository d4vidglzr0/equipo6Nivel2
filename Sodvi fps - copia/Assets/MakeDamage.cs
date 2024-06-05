using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
    public int damage = 20;
    private void OnTriggerEnter(Collider other) { 
        if (other.tag == "Player")
        {
            GameManager.Instance.LoseHealth(damage);
        }
    }
    

}
