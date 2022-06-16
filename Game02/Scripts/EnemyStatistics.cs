using UnityEngine;

public class EnemyStatistics : MonoBehaviour
{
    public Enemy enemy;
    public float health;
    private bool isDead;
    private Rigidbody2D rb;

    // Update is called once per frame
    void Awake()
    {
        health = enemy.health;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        isDead = false;
    }
    void FixedUpdate()
    {
        if (health <= 0)
        {
            isDead = enemy.isDead = true; // add a death animation
            Destroy(gameObject);
        }
    }
}
