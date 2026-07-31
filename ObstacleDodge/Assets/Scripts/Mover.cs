using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using WASD or arrow keys.");
        Debug.Log("Dodge the obstacles!");
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float moveY = 0f;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Translate(moveX, moveY, moveZ);
    }
}
