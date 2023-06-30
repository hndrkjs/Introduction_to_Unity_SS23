using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private NavMeshAgent agent;

    [SerializeField]
    private LayerMask groundLayer;
    [SerializeField]
    private LayerMask playerLayer;

    // patrol
    Vector3 destination;
    bool hasDestination;
    [SerializeField]
    private float walkRange;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player_Car");
    }

    // Update is called once per frame
    void Update()
    {
        MovingAround();
    }

    void MovingAround()
    {
        // if the agent has no destination we need to set a new destination
        if (!hasDestination) {
            GetDestination();

        }

        // if the agent has a destination, it should walk towards that destination
        if (hasDestination) {
            agent.SetDestination(destination);
        }

        // if the agent has almost reached it's destination, we will get him a new destination
        if (Vector3.Distance(transform.position, destination) < 10) {
            hasDestination = false;
        }
    }

    void GetDestination()
    {

        // get x and z values for the agent to walk towards to
        float x = Random.Range(-walkRange, walkRange);
        float z = Random.Range(-walkRange, walkRange);
        

        destination = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);

        // check whether the random destiantion is a viable destination to walk to 
        if (Physics.Raycast(destination,Vector3.down,groundLayer)){
            hasDestination= true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            other.GetComponent<Player>().Damage();
        }
    }

}



