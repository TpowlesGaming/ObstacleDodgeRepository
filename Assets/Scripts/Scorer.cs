using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    // Occurs when a collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            // Updates score by 1 on player collision.
            hits++;

            // Prints console log with current score
            Debug.Log($"You've hit {hits.ToString()} objects!");
        }
    }
}
