using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{
    public float projectileDamage = 25f;
    
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
