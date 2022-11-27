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
        
        if (progress == 3)
        {
            SceneManager.LoadScene("C3_Level_1");
        }
        
        if (progress == 4)
        {
            SceneManager.LoadScene("C4_Level_1");
        }

        if (progress == 5)
        {
            SceneManager.LoadScene("Softlock");
        }
    }

    
}
