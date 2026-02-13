using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;

    private void Start()
    {
        // Destroy this projectile after 2 seconds to avoid cluttering the scene
        Destroy(gameObject, 2f);
    }

    private void Update()
    {
        // Move continuously to the right
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Don't destroy projectile if it hits the player
        if (other.GetComponent<PlayerHealth>() != null)
        {
            return; // Let projectile pass through player
        }

        // Destroy projectile when hitting enemy or other objects
        // Enemy script will handle the destruction and scoring
        if (!other.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }
    }
}


