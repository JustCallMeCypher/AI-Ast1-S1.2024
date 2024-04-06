using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
    public enum DoorState
    {
        Opening,
        Open,
        Closing,
        Close
    }

    public DoorState state;
    private Vector3 closedPosition;
    private Vector3 openPosition;
    public float speed = 5f;
    public Vector3 deltaPosition = new Vector3(0f, -2f, 0f);

    private float timer = 0f;
    public float delay = 3f;

    void Start()
    {
        state = DoorState.Close;

        closedPosition = transform.position;
        openPosition = transform.position + deltaPosition;
    }

    void Update()
    {
        switch(state)
        {
            case DoorState.Opening:
                OpenTheDoor(openPosition);


                if (Vector3.Distance(transform.position, openPosition) < 0.01f)
                {
                    state = DoorState.Open;
                }
                break;
            case DoorState.Open:
                timer += Time.deltaTime;

                if(timer > delay)
                {
                    state = DoorState.Closing;
                }
                break;
            case DoorState.Closing:
                OpenTheDoor(closedPosition);

                if (Vector3.Distance(transform.position, closedPosition) < 0.01f)
                {
                    state = DoorState.Close;
                }
                break;
            case DoorState.Close:
                timer += Time.deltaTime;

                if (timer > delay)
                {
                    state = DoorState.Opening;
                }
                break;
            default:
                //if there are any other cases default is used
                //default in this switch does nothing
                break;
        }
    }

    public void OpenTheDoor(Vector3 targetPosition)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

}
