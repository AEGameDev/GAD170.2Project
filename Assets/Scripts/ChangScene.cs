using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangScene : MonoBehaviour
{
    // This function allows the player to begin the game transitioning from startScene to gameScene
    public void MoveToScene()
    {
       SceneManager.LoadScene("GameScene");
    }

}
