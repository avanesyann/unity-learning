using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float spinX = 0f;
    [SerializeField] private float spinY = 0.1f;
    [SerializeField] private float spinZ = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinX, spinY, spinZ);
    }
}
