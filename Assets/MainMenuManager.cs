using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject layer1;
    [SerializeField] private GameObject layer2;
    //[SerializeField] private int level;
    public void LoadLevel(int level)
    {
        SceneManager.LoadScene(level + 1);
    }

    public void ShowLevels()
    {
        layer2.SetActive(true);
        layer1.SetActive(false);
    }

    public void HideLevels()
    {
        layer1.SetActive(true);
        layer2.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
