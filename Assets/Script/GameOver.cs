using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button mainMenuButton;
    public Button Restart;
    
    private void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
        Restart.onClick.AddListener(SampleScene);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
