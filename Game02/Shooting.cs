using UnityEngine;

public class Shooting : MonoBehaviour
{
    private GameObject player;
    private PlayerShoot PlayerShoot;
    private Transform playerTransform;

    public GameObject projectile;

    public float m_shootOffset = 1f;

    public float m_projectileForce = 100f;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");
        playerTransform = player.transform;
        PlayerShoot = player.GetComponent<PlayerShoot>();
    }

    // Update is called once per frame
    void Update()
    {

        // move fire point
        FirePoint();
        transform.rotation = Quaternion.Euler(0, 0, PlayerShoot.m_angle*180/Mathf.PI);

        // instanstiate projectile and fire
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject proj = Instantiate(projectile, transform.position, transform.rotation);
        Rigidbody2D rigidbody = proj.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.right * m_projectileForce, ForceMode2D.Impulse);
    }

    void FirePoint()
    {

        transform.position = new Vector3(m_shootOffset * Mathf.Cos(PlayerShoot.m_angle) + playerTransform.position.x, m_shootOffset * Mathf.Sin(PlayerShoot.m_angle) + playerTransform.position.y, 0);
       
    }
}
