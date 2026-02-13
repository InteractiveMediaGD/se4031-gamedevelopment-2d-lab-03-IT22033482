using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [Header("Projectile")]
    public GameObject projectilePrefab;

    private void Update()
    {
        // Left mouse button (or first touch) shoots a projectile
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (projectilePrefab != null)
            {
                Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("Projectile prefab is not assigned on PlayerShoot.");
            }
        }
    }
}


