using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Occurs when a collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        PrintCollisionMessage();
    }

    private void PrintCollisionMessage()
    {
        // Prints object hit message to the console.
        Debug.Log("Object Hit!");
    }
}
