using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = new Color(0.30f, 0f, 0f);
            gameObject.tag = "Hit";
        }
    }
}
