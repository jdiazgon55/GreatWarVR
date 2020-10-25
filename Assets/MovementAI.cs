using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAI : MonoBehaviour
{

    public bool shouldWander = false;
    public float wanderRadius;
    public float wanderTimer;
    public float rotationSpeed = 1;
 
    private Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
    private float timer;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
        timer = wanderTimer;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldWander) {
        timer += Time.deltaTime;
 
            if (timer >= wanderTimer) {
                Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                agent.SetDestination(newPos);
                timer = 0;
            }
        } else {
                agent.SetDestination(player.transform.position);
                Vector3 rotationVec = player.transform.position - transform.position;
                rotationVec.y = 0; //This allows the object to only rotate on its y axis
                Quaternion rot = Quaternion.LookRotation(rotationVec);
                transform.rotation = Quaternion.Lerp(transform.rotation, rot, rotationSpeed * Time.deltaTime);
        }
    }

    private static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask) {
        Vector3 randDirection = Random.insideUnitSphere * dist;
 
        randDirection += origin;
 
        UnityEngine.AI.NavMeshHit navHit;
 
        UnityEngine.AI.NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);
 
        return navHit.position;
    }
}
