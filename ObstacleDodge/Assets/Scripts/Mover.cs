using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    void Start()
    {
    }

    void Update()
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
}
