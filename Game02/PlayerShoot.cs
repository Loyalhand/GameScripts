using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public new Camera camera;

    Vector3 m_mousePosition;
    Vector3 m_posMouseCam;

    public float m_angle;

    // Start is called before the first frame update
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        m_mousePosition.x = Input.mousePosition.x;
        m_mousePosition.y = Input.mousePosition.y;
        m_mousePosition.z = -camera.transform.position.z;
        m_posMouseCam = camera.ScreenToWorldPoint(m_mousePosition);


    }

    void FixedUpdate()
    {
        Vector3 shootDirection = m_posMouseCam - transform.position;
        
        m_angle = Mathf.Atan2(shootDirection.y, shootDirection.x);

        Debug.Log(m_angle);
    }
}
