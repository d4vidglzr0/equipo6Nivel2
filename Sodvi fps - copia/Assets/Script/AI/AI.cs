using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class AI : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] destinations;
   
    
    
    private int puntos = 0;
    [Header("---------FollowPLayer--------")]
    public bool folLowPlayer;
    private GameObject player;
    private float distanceToPlayer;
    public float distanceToFollow = 10;
    public float distanceToPath = 2;

    void Start()
    {
        navMeshAgent.destination = destinations[0].transform.position;
        player = FindObjectOfType<PlayerMovement>().gameObject;
    }

    
    void Update()
    {
       distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer <= distanceToFollow && folLowPlayer)
        {
            FollowPlayer(); 
        }
        else
        {
            EnemyPath();
        }
    }

    public void EnemyPath()//rutinas de destinos
    {
    navMeshAgent.destination = destinations[puntos].position;
        if (Vector3.Distance(transform.position, destinations[puntos].position) <= distanceToPath) 
        {
            if (destinations[puntos] != destinations[destinations.Length-1]) { 
                puntos++;
            }
            else {
                puntos = 0;
            }
        }
    }

    public void FollowPlayer()//seguir al jugador
    {
        navMeshAgent.destination = player.transform.position;
    }
}
