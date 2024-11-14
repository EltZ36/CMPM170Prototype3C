using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginSceneController : MonoBehaviour
{

    public void OnStartGame()
    {
        SceneManager.LoadScene("GameScene");
    }


    public void OnExitGame()
    {
        Application.Quit();
    }


    public void OnShowReference()
    {

        Debug.Log("show reference");
    }
}
