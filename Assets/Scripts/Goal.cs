using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public string sceneName;
    public int errorMessages;

    /*private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("errorSpawn", errorMessages);
            SceneManager.LoadScene(sceneName);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("errorSpawn", errorMessages);
            SceneManager.LoadScene(sceneName);
        }
    }
}
