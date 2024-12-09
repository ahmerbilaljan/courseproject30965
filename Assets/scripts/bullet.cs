using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    float bulletSpeed = 8f; 
    private Rigidbody2D rb;  

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, bulletSpeed);

        Vector2 maxPosition = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        if (transform.position.y > maxPosition.y)
        {
            Destroy(gameObject);
        }
    }
}
