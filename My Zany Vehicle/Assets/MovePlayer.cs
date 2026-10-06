using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] public float maxSpeed = 20f;
    [SerializeField] public float acceleration = 10f;
    [SerializeField] public float deceleration = 3f;
    [SerializeField] public float brakeDeceleration = 15f;

    private float currentSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (currentSpeed < 0)
            {
                currentSpeed = Mathf.MoveTowards(currentSpeed, 0, brakeDeceleration * Time.deltaTime);
            }
            else
            {
                currentSpeed = Mathf.MoveTowards(currentSpeed, maxSpeed, acceleration * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (currentSpeed > 0)
            {
                currentSpeed = Mathf.MoveTowards(currentSpeed, 0f, brakeDeceleration * Time.deltaTime);
            }
            else
            {
                currentSpeed = Mathf.MoveTowards(currentSpeed, -maxSpeed, brakeDeceleration * Time.deltaTime);
            }
        }
        else
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0f, deceleration * Time.deltaTime);
        }

        transform.Translate(Vector3.right * currentSpeed * Time.deltaTime, Space.Self);


        // float moveX = Input.GetAxis("Vertical");
        // float moveZ = Input.GetAxis("Horizontal");

        // Vector3 movement = new Vector3(moveX, 0f, -moveZ);

        // transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
