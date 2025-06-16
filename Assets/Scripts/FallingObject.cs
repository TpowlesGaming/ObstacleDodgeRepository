using UnityEngine;

public class FallingObject : MonoBehaviour
{
    // Initialize variables
    [SerializeField] float timeToWait = 3f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Assign object components
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        // Starts the object without MeshRenderer or Gravity enabled.
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Executes when game has been running for an amount of time equal to timeToWait.
        if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
