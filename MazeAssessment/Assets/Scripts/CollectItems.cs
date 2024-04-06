using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    [SerializeField] private int collectedObjects = 0;

    private OpenDoor door;

    private void Update()
    {
        if (collectedObjects >= 3)
        {
            door.OpenTheDoor();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Collectable")
        {
            collectedObjects++;
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
