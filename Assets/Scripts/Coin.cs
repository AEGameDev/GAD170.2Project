using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    // This script allows the player to win the game by colliding with the coin
    private void OnCollisionEnter2D(Collision2D coinCollision)
    {
        if (coinCollision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("VictoryScene");           
        }
    }
}
