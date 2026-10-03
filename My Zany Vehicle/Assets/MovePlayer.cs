using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Vertical");
        float moveZ = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveX, 0f, -moveZ);

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
