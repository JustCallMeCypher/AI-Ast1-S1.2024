using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinMove : MonoBehaviour
{
    public enum GoblinPoints
    {
        PointOne,
        PointTwo, 
        PointThree, 
        PointFour,
    }
    public GoblinPoints state;

    public NavMeshAgent agent;

    public GameObject coinOne;
    public GameObject coinTwo;
    public GameObject coinThree;
    public GameObject coinFour;

    public float timer;
    public float waitTime = 7f;


    // Start is called before the first frame update
    void Start()
    {
        state = GoblinPoints.PointOne;
        Debug.Log("'You'll...  ...kill the Children too...?'"); //Priestess Speaking
        Debug.Log("'Of course I will. We've destroyed their nest. They'll never forget that. And the survivors of a nest learn, become smarter.'"); //Goblin Slayer Speaking
        Debug.Log("There is no reason to let them live.'"); //Goblin Slayer Speaking
        Debug.Log("'Wh... What if it were a good goblin......?'"); //Priestess Speaking
        Debug.Log("'A good goblin? There might be one, if we looked. But I think..."); //Goblin Slayer Speaking
        Debug.Log("...The only good goblins are the ones who never come out of their stinking holes. That's twenty-two'"); //Goblin Slayer Speaking
        Debug.Log("- Goblin Slayer telling Priestess his harsh reality.");
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case GoblinPoints.PointOne:
                agent.destination = coinOne.transform.position;
                timer += Time.deltaTime;
                if(timer > waitTime)
                {
                    state = GoblinPoints.PointTwo;
                    timer = 0;
                }
                break;
            case GoblinPoints.PointTwo:
                agent.destination = coinTwo.transform.position;
                timer += Time.deltaTime;
                if(timer > waitTime)
                {
                    state = GoblinPoints.PointThree;
                    timer = 0;
                }
                break;
            case GoblinPoints.PointThree:
                agent.destination = coinThree.transform.position;
                timer += Time.deltaTime;
                if (timer > waitTime)
                {
                    state = GoblinPoints.PointFour;
                    timer = 0;
                }
                break;
            case GoblinPoints.PointFour:
                agent.destination = coinFour.transform.position;
                timer += Time.deltaTime;
                if (timer > waitTime)
                {
                    state = GoblinPoints.PointOne;
                    timer = 0;
                }
                break;
            default:
                break;
        }
    }
}
