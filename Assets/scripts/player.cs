using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 3f;
    public GameObject PlayerBullet; 
    public GameObject BulletSpawn;
    private Rigidbody2D rb;
     public AudioSource audioSource;  // Drag your AudioSource here in the Inspector
    public AudioClip collisionSound; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * maxSpeed;
        float moveY = Input.GetAxis("Vertical") * maxSpeed;

        rb.velocity = new Vector2(moveX, moveY);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet1 = Instantiate(PlayerBullet);
            bullet1.transform.position = BulletSpawn.transform.position;
            audioSource.PlayOneShot(collisionSound);

        }
    }
}
