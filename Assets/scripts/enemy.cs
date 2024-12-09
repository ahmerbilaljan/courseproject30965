using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int points = 10;
     public GameObject explosionPrefab;
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            GameManager.instance.AddScore(points);
            
            Destroy(gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            
        }

         if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            GameManager.instance.GameOver();
        }
    }
}
