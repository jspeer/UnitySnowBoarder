using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public IEnumerator LoadSceneWithTimer(string sceneName, float waitTime)
    {
        // Pause
        Time.timeScale = 0;
        // Wait the defined time
        yield return new WaitForSecondsRealtime(waitTime);
        // Load the new scene
        SceneManager.LoadScene(sceneName);
        // Unpause
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
