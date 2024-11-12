using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int playerHealth = 0;
    public int playerMaxHealth = 100;
    public int playerAttack = 10;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // Sets player health to max health
        playerHealth = playerMaxHealth;
    }
    public void OnCollisionEnter2D(Collision2D enemyCollision)
    {
        // If player collides with enemy, the player takes random damage amount and debugs remaining health

        if (enemyCollision.gameObject.CompareTag("Enemy"))
        {
            playerHealth -= Random.Range(20,50);
            Debug.Log("Player Took Damage, Health Remaining = " +playerHealth);
        }

        // If player takes damage reducing them to 0 health or below debugs they die and scene changes

        if (playerHealth <= 0)
        {
            Destroy(player);
            Debug.Log("Player Died!");
            SceneManager.LoadScene("DeathScene");
        }
    }
}
