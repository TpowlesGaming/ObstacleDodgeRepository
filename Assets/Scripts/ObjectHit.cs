using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Occurs when a collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Changes color to red when the player collides with the object.
            GetComponent<MeshRenderer>().material.color = Color.red;

            gameObject.tag = "Hit";
        }
    }
}
