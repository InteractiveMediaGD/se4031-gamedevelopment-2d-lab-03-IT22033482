using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [Header("Health")]
    public int maxHealth = 100;
    public int currentHealth;

    [Header("UI")]
    public TMP_Text healthText;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateUI();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateUI();

        if (currentHealth <= 0)
        {
            Debug.Log("Player died");
            // Add death / restart logic here if needed
        }
    }

    private void UpdateUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth;
        }

        // Lab sheet creative feature option 1: change health text colour
        if (healthText != null)
        {
            if (currentHealth > 60)
                healthText.color = Color.green;
            else if (currentHealth > 30)
                healthText.color = Color.yellow;
            else
                healthText.color = Color.red;
        }
    }
}



