using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject spinner;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            spinner.SetActive(true);
        }
    }
}
