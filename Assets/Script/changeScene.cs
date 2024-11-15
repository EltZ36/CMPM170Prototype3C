using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void MenuScene()
    {
        SceneManager.LoadScene("BeginScene");
    }
    public void CreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }
    public void PlayScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void quitGame()
    {
        Application.Quit();
    }

}
