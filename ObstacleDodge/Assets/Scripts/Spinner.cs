using UnityEngine;
using UnityEngine.UIElements;

public class Spinner : MonoBehaviour
{
    [SerializeField] float angleX = 0f;
    [SerializeField] float angleY = 360f;
    [SerializeField] float angleZ = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(angleX * Time.deltaTime, angleY * Time.deltaTime, angleZ * Time.deltaTime);
    }
}
