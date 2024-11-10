using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyWizard : MonoBehaviour
{
    public int enemyHealth = 0;
    public int enemyMaxHealth = 200;
    public int enemyAttack = 20;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // Sets Enemy Health
        enemyHealth = enemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter2D(Collision2D enemyCollision)
    {
        if (enemyCollision.gameObject.CompareTag("Player"))
        {
            Debug.Log("The Wizard Destroyed You!");
        }
    }
}
