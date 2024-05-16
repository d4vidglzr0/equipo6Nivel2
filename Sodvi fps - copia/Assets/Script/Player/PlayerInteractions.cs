using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public Transform startPosition; 
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pills"))
        {
            GameManager.Instance.gunAmmo += other.gameObject.GetComponent<AmmoBox>().ammo;

            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("DeathFloor"))//PERDER VIDA Y RESPAWN
        {
            GameManager.Instance.LoseHealth(20);

            GetComponent<CharacterController>().enabled = false;
            gameObject.transform.position = startPosition.position;
            GetComponent<CharacterController>().enabled = true;

        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            GameManager.Instance.LoseHealth(10);   
        }
    }
}
