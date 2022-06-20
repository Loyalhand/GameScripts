using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{
    public Projectile projectile;
    float projectileDamage;

    private void Awake()
    {
        // make items -> put Projectile scriptable object on item -> pull damage from item
        projectileDamage = projectile.damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyStatistics enemy = collision.GetComponent<EnemyStatistics>();
            enemy.health -= projectileDamage;
            Destroy(gameObject);
            Debug.Log(enemy.health);
        }
    }
}
