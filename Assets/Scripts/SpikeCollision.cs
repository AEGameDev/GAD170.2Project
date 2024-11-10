using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollision : MonoBehaviour
{
    public Player playerHealth;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D spikeCollision)
    {

        if (spikeCollision.gameObject.CompareTag("Player"))
        {
           SceneManager.LoadScene("DeathScene");
        }
    }
}
