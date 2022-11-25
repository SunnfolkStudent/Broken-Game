using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int progress;

    private void Start()
    {
        progress = PlayerPrefs.GetInt("Progress");
        if (progress == 1)
        {
            SceneManager.LoadScene("C_Level_1");
        }
        
        if (progress == 2)
        {
            SceneManager.LoadScene("C2_Level_1");
        }
    }
}
