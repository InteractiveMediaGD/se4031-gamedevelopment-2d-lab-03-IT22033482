using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    public int damage = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Projectile hit - check tag first to avoid errors
        if (other.CompareTag("Projectile"))
        {
            // Find ScoreManager in the scene and add score as per lab sheet
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(5);
            }

            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }

        // Player hit - only damage player, don't affect score
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}


