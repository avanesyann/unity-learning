using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop = 3f;
    // Caching is a technique of storing frequently used data or information in memory
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }
    void Update()
    {
        if (Time.time >= timeToDrop)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
