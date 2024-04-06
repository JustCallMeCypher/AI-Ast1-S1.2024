using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    public enum DestroyState
    {
        None,
        Delay,
        Destroy
    }
    public DestroyState state;


    public float timer;
    public float waitTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        state = DestroyState.None;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case DestroyState.None:
                break;
            case DestroyState.Delay:
                timer += Time.deltaTime;
                if (timer > waitTime)
                {
                    state = DestroyState.Destroy;
                }
                break;
            case DestroyState.Destroy:
                Destroy(gameObject);
                state = DestroyState.None;
                break;
            default:
                break;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        switch(state)
        {
            case DestroyState.None:
                state = DestroyState.Delay;
               break;
                default:
                state = DestroyState.Delay;
                break;
        }
    }


}
