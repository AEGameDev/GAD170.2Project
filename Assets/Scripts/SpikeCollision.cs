using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollision : MonoBehaviour
{
    public Player playerHealth;

    // When player collides with spikes, player dies and scene switches

    private void OnCollisionEnter2D(Collision2D spikeCollision)
    {

        if (spikeCollision.gameObject.CompareTag("Player"))
        {
           SceneManager.LoadScene("DeathScene");
        }
    }
}
