using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.AI;

public class MoveToObject : MonoBehaviour
{
    public NavMeshAgent agent;
    
    public GameObject key;

    public GameObject end;

    public bool collectedKey = false;
    



    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (key != null)
        {
            agent.destination = key.transform.position;
            
        }
        else
        {
            collectedKey = true;
            agent.destination = end.transform.position;
        }
        
    }
}
