using UnityEngine;

public class Braking : MonoBehaviour
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
        if (car.currentSpeed > 0 && Input.GetKey(KeyCode.S))
        {
            lightRenderer.material.color = new Color(196f / 255f, 30f / 255f, 58f / 255f, 255f / 255f);
        }
        else
        {
            lightRenderer.material.color = originalColor;
        }
    }
}
