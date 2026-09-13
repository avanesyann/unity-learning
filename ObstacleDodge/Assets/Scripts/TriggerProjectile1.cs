using UnityEngine;

public class TriggerProjectile1 : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            foreach (var projectile in projectiles)
            {
                projectile.SetActive(true);
            }
        }
    }
}
