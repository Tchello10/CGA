using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string playSceneName;
    [SerializeField] private string menuScene;
    public void Play()
    {
        SceneManager.LoadScene(playSceneName);
    }

    public void Menu()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void Quit()
    {
        Debug.Log("quitou :(");
        Application.Quit();
    }
}
