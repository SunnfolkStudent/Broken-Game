using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    //public float jumpForce = 8f;
    public Rigidbody2D _rigidbody2D;

    private Vector2 _moveVector;
    private bool _groundHit;
    public JumpCheck jumpCheck;

    private void Update()
    {
        _groundHit = jumpCheck.groundHit;

        _moveVector.x = (Keyboard.current.dKey.isPressed ? 1f : 0f) + (Keyboard.current.aKey.isPressed ? -1f : 0f);
        
        transform.Translate(_moveVector * moveSpeed * Time.deltaTime);

        

        /*if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            PlayerPrefs.SetInt("Progress", 0);
            PlayerPrefs.SetInt("errorSpawn", 0);
        }*/
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Death"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (col.gameObject.CompareTag("EndBox"))
        {
            Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
        }
    }
    
}
