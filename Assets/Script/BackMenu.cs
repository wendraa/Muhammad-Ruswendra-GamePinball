using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackMenu : MonoBehaviour
{
    public Button MenuBack;

    public void exitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
