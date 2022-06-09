using UnityEngine;

public class Pickup : MonoBehaviour
{
    
    public float range = .5f;
    private LayerMask layerMask;


    private void Start()
    {
        layerMask = LayerMask.GetMask("Collectibles");
    }

    private void Update()
    {
        pickUp();
    }

    void pickUp()
    {
        Collider2D[] detection = Physics2D.OverlapCircleAll(transform.position, range, layerMask);

        foreach (Collider2D item in detection)
        {
            Destroy(item.gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (transform == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(transform.position, range);
    }
}
