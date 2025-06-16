using UnityEngine;

public class Spin : MonoBehaviour
{
    // Variable for spinning speed of the obstacle.
    [SerializeField] float spinSpeed = 100f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Declare Variables
        float xValue = 0;
        float yValue = Time.deltaTime * spinSpeed;
        float zValue = 0;

        // Move by values
        transform.Rotate(xValue, yValue, zValue);
    }
}
