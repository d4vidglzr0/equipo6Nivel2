using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public int Damage = 25;
        private void OnCollisionEnter(Collision collsion)
        {
            if (collsion.gameObject.CompareTag("Enemy"))
                {
                   collsion.gameObject.GetComponent<LooseLife>().Loose(Damage);
                }
        
            }
        }
