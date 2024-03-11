using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button aboutButton;

    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void AboutGame()
    {
        SceneManager.LoadScene("Intro");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
