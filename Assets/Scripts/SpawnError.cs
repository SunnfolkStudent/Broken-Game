using UnityEngine;

public class SpawnError : MonoBehaviour
{
    public GameObject messageInterface;
    public int errorEnable;

    public void Start()
    { 
        errorEnable = PlayerPrefs.GetInt("errorSpawn");

        if (errorEnable == 1)
        {
            Instantiate(messageInterface, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
