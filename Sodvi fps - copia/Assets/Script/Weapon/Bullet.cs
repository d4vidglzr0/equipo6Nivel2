using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ 
        private void OnCollisionEnter(Collision collsion)
        {
            if (collsion.gameObject.CompareTag("Enemy"))
                {
                Destroy(collsion.gameObject);
                }
        
            }
        }
