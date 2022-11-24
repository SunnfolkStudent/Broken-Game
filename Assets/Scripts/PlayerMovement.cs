using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float jumpForce = 8f;
    public Rigidbody2D _rigidbody2D;

    private Vector2 _moveVector;
    private bool _groundHit;

    private void Update()
    {

        _moveVector.x = (Keyboard.current.dKey.isPressed ? 1f : 0f) + (Keyboard.current.aKey.isPressed ? -1f : 0f);
        
        transform.Translate(_moveVector * moveSpeed * Time.deltaTime);

        if (_groundHit && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
            _groundHit = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            _groundHit = true;
            print("true");
        }

        if (col.gameObject.CompareTag("Death"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (col.gameObject.CompareTag("EndGame"))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }

    }
}
