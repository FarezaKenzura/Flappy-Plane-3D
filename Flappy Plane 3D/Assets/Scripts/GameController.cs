using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreManager.ResetScore();
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
