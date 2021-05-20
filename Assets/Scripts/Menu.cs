using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject settingsWindow;

    [SerializeField]
    private PlayableDirector startCatScene;
    public void Play()
    {
        startCatScene.Play();
    }

    public void OpenSettingsWindow()
    {
        settingsWindow.SetActive(true);
    }
    public void QuitTheGame()
    {
        Application.Quit();
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
