using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    public void Restart()
    {
        ScoreManager.ResetLevel();
        canvas.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnMainMenu()
    {
        ScoreManager.ResetLevel();
        canvas.gameObject.SetActive(false);
        SceneManager.LoadScene(1);
    }
}
