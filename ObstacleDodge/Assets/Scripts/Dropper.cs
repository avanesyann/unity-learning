using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] public float dropTime = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTime)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
