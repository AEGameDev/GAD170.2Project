using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerHealth = 0;
    public int playerMaxHealth = 100;
    public int playerAttack = 10;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = playerMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
