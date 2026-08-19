using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject spinner;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bububu");
        if (other.gameObject.tag == "Player")
        {
            spinner.SetActive(true);
            Debug.Log("Bup");
        }
    }
}
