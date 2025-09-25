using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float projectileSpeed = 1.0f;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        ProjectileToPlayer();
        DestroyProjectile();
    }

    void ProjectileToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, projectileSpeed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
