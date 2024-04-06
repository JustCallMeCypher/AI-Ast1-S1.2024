using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof(NavMeshAgent))]
public class ClickToMove : MonoBehaviour
{

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // left click input
        if(Input.GetMouseButton(0))
        {
            // creates a ray from camera to mouse
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

            if(Physics.Raycast(ray.origin, ray.direction, out hitInfo)) 
            {
                agent.destination = hitInfo.point;
            }
            
            
        }
    }
}
