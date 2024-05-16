using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemyBullet;
    public Transform spawnBulletPoint;
    private Transform PlayerPosition;
    private float bulletVelocity=200;
    void Start()
    {
        PlayerPosition = FindObjectOfType<PlayerMovement>().transform;
        Invoke("ShootPlayer",3);
    }

    
    void Update()
    {
        

    }
    
    void ShootPlayer(){
         Vector3 PlayerDirection = PlayerPosition.position - transform.position;

        GameObject newBullet;

        newBullet = Instantiate(enemyBullet,spawnBulletPoint.position,spawnBulletPoint.rotation);

        newBullet.GetComponent<Rigidbody>().AddForce(PlayerDirection*bulletVelocity, ForceMode.Force);

        Invoke("ShootPlayer", 3);
    }

}
