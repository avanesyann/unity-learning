using UnityEngine;

public class Reverse : MonoBehaviour
{
    private Renderer lightRenderer;
    private Color originalColor;

    [SerializeField] private MovePlayer car;

    void Start()
    {
        lightRenderer = GetComponent<Renderer>();
        originalColor = lightRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (car.currentSpeed < 0)
        {
            lightRenderer.material.color = Color.white;
        }
        else
        {
            lightRenderer.material.color = originalColor;
        }
    }
}
