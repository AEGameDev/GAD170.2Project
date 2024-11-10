using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    // Allows player to transition to main menu scene by interacting with UI
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
