using UnityEngine;

public class Mover : MonoBehaviour
{
    float moveX = 0f;
    float moveY = 0.01f;
    float moveZ = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveX, moveY, moveZ);
    }
}
