using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Image errorMessage;
    public AudioSource error;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Destruct()
    {
        Destroy(errorMessage.gameObject);
    }

    private void Start()
    {
        error.Play();
    }
}
