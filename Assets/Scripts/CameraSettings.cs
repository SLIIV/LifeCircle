using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraSettings : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseObject;
    public static bool isPause;
    void Start()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isPause = false;
    }

    public void ContinueGame()
    {
        isPause = false;
        Time.timeScale = 1;
        pauseObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void QuitTheGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = true;
            Time.timeScale = 0;
            pauseObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
