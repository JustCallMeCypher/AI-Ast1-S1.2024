using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    [SerializeField] private GameObject key;

    private MoveToObject moveToObject;

    private OpenDoor door;


    private void Update()
    {
        if (moveToObject.collectedKey == true)
        {
            door.OpenTheDoor();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Key")
        {
            moveToObject.collectedKey = true;
            Destroy(collision.gameObject);
            //Debug.Log("Collieded with: " + collision.gameObject.name);
        }

        /*
        
         Collectable collectable = collision.gameObject.GetComponent<Collectable>();

        if (collectable != null)
        {
            collectedObjects++;
            Destroy(collision.gameObject);
        }

        */

    }
}
