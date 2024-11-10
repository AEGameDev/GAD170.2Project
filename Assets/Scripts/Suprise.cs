using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Suprise : MonoBehaviour
{
    public void SupriseFight()
    {
        SceneManager.LoadScene("BossScene");
    }
}
