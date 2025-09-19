using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("Bump!");

        GetComponent<MeshRenderer>().material.color = new Color(0.30f, 0f, 0f);
    }
}
