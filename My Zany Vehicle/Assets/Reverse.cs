using UnityEngine;

public class Reverse : MonoBehaviour
{
    private Renderer lightRenderer;
    private Color originalColor;

    void Start()
    {
        lightRenderer = GetComponent<Renderer>();
        originalColor = lightRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            lightRenderer.material.color = Color.white;
        }
        else
        {
            lightRenderer.material.color = originalColor;
        }
    }
}
