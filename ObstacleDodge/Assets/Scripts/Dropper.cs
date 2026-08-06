using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] public float dropTime = 2f;

    MeshRenderer dropperMesh;
    Rigidbody dropperRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dropperMesh = GetComponent<MeshRenderer>();
        dropperRb = GetComponent<Rigidbody>();

        dropperMesh.enabled = false;
        dropperRb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTime)
        {
            dropperRb.useGravity = true;
            dropperMesh.enabled = true;
        }
    }
}
