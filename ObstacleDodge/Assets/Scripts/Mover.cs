using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {

        // instead of handling x, y, z separately, we could (and should) work with a Vector3
        // Unity's API is built around vectors

        // float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        // float yValue = 0f;
        // float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // transform.Translate(xValue, yValue, zValue);

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Press W-A-S-D to move.");
        Debug.Log("Don't bump into objects!");
    }
}
