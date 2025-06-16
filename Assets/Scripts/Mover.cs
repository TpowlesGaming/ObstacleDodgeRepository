using UnityEngine;

public class Mover : MonoBehaviour
{
    // Variable for movement speed of the player.
    [SerializeField] float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Prints out game instructions to the console on game start.
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        // Implements XYZ movement for the player.
        MovePlayer();
    }

    private void PrintInstructions()
    {
        // Prints instruction to the console.
        Debug.Log("Welcome to the game.");
        Debug.Log("Use WASD or arrow keys to move.");
        Debug.Log("Don't bump into objects.");
    }

    private void MovePlayer()
    {
        // Declare Variables
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = Input.GetAxis("Jump") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // Move by values
        transform.Translate(xValue, yValue, zValue);
    }
}
