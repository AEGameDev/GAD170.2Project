using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wizardPrefab;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        // This spawns an enemy at between random range on platform

        float x = Random.Range(0, 1.75f);
        float y = Random.Range(0, -0.5f);


        Instantiate(wizardPrefab, new Vector2(x,y), Quaternion.identity);
    }
}
