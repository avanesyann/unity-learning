using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float moveY = 0f;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Translate(moveX, moveY, moveZ);
    }
}
