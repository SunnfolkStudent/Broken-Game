using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int scene;
    public int progress;

    private void Start()
    {
        progress = PlayerPrefs.GetInt("Progress");
        if (progress == 1)
        {
            SceneManager.LoadScene("Level_2");
        }
    }
}
