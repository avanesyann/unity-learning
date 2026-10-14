using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [Header("Speed")]
    public float maxSpeed = 20f;
    public float acceleration = 8f;
    public float brakeDeceleration = 15f;
    public float deceleration = 5f;
    public float reverseSpeed = 8f;

    [Header("Steering")]
    public float steeringSpeed = 90f;
    public float steeringSmoothness = 5f;

    public float currentSpeed;
    public float horizontalInput;

    void Update()
    {
        HandleMovement();
        HandleSteering();
    }

    void HandleMovement()
    {
        float verticalInput = Input.GetAxisRaw("Vertical");

        if (verticalInput > 0)
        {
            if (currentSpeed < 0)
            {
                // Brake before moving forward.
                currentSpeed = Mathf.MoveTowards(
                    currentSpeed, 0f,
                    brakeDeceleration * Time.deltaTime
                );
            }
            else
            {
                currentSpeed = Mathf.MoveTowards(
                    currentSpeed, maxSpeed,
                    acceleration * Time.deltaTime
                );
            }
        }
        else if (verticalInput < 0)
        {
            if (currentSpeed > 0)
            {
                // Brake before reversing.
                currentSpeed = Mathf.MoveTowards(
                    currentSpeed, 0f,
                    brakeDeceleration * Time.deltaTime
                );
            }
            else
            {
                currentSpeed = Mathf.MoveTowards(
                    currentSpeed, -reverseSpeed,
                    acceleration * Time.deltaTime
                );
            }
        }
        else
        {
            // Gradually slow down when no input is pressed.
            currentSpeed = Mathf.MoveTowards(
                currentSpeed, 0f,
                deceleration * Time.deltaTime
            );
        }

        transform.Translate(
            Vector3.forward * currentSpeed * Time.deltaTime,
            Space.Self
        );
    }

    void HandleSteering()
    {
        float targetSteering = Input.GetAxisRaw("Horizontal");

        horizontalInput = Mathf.MoveTowards(
            horizontalInput,
            targetSteering,
            steeringSmoothness * Time.deltaTime
        );

        // Reduce steering while moving slowly.
        float speedFactor = Mathf.Clamp01(
            Mathf.Abs(currentSpeed) / 3f
        );

        // Reverse steering direction while reversing.
        float reverseFactor = currentSpeed < 0 ? -1f : 1f;

        transform.Rotate(
            Vector3.up,
            horizontalInput * steeringSpeed *
            speedFactor * reverseFactor * Time.deltaTime
        );
    }
}
