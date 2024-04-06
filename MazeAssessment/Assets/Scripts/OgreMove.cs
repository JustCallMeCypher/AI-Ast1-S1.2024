using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation.Editor;
using UnityEngine;
using UnityEngine.AI;

public class OgreMove : MonoBehaviour
{
    public NavMeshAgent agent;

    public GameObject human;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = human.transform.position;
    }
}
