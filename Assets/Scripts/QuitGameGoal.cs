using UnityEngine;

public class QuitGameGoal : MonoBehaviour
{
    [Header("Error messages")]
    public GameObject messageInterface;
    
    public int progress;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("EndGame"))
        {
            progress = PlayerPrefs.GetInt("Progress");
            Instantiate(messageInterface, new Vector3(0, 0, 0), Quaternion.identity);
            progress = 1;
            PlayerPrefs.SetInt("Progress", progress);
            Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
        }
        if (col.gameObject.CompareTag("EndGame2"))
        {
            Instantiate(messageInterface, new Vector3(0, 0, 0), Quaternion.identity);
            progress = 2;
            PlayerPrefs.SetInt("Progress", progress);
            Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
        }
        if (col.gameObject.CompareTag("EndGame3"))
        {
            Instantiate(messageInterface, new Vector3(0, 0, 0), Quaternion.identity);
            progress = 3;
            PlayerPrefs.SetInt("Progress", progress);
            Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
