using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public Transform spawnPoint;

    public GameObject bullet;

    public float shotForce = 5000f;

    public float Cadence = 0.3f;

    private float shotRateTime = 0;

    private AudioSource AudioSource;

    public AudioClip shotsound;

   private void Start()
    {
      AudioSource = GetComponent<AudioSource>();  
    }



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))//disparar
        {
            

            if (Time.time>shotRateTime && GameManager.Instance.gunAmmo>0) 

            {
             AudioSource.PlayOneShot(shotsound);   

            GameManager.Instance.gunAmmo--;
            GameObject newBullet;

            newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

            newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);

            shotRateTime= Time.time+Cadence;

            Destroy(newBullet,2);

            }     

        }
        
    }
}
