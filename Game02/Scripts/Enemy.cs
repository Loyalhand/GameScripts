using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class Enemy : ScriptableObject
{
    public float health;
    public float regeneration;
    public float attackPower;
    public bool isDead;

    public void Died()
    {
        if (health <= 0)
        {
            isDead = true;
        }
    }

    public void Regeneration()
    {
        health += regeneration;
    }
}
