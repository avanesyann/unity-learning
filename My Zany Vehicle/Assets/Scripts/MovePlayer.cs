using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] public float maxSpeed = 20f;
    [SerializeField] public float acceleration = 10f;
    [SerializeField] public float deceleration = 3f;
    [SerializeField] public float brakeDeceleration = 15f;
    [SerializeField] public float horizontalInput = 0f;

    public float currentSpeed;

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

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput = 0.3f;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput = -0.3f;
        }

        transform.Translate(Vector3.right * currentSpeed * Time.deltaTime, Space.Self);

        transform.Translate(Vector3.forward * horizontalInput * 5f * Time.deltaTime, Space.Self);
    }
}
