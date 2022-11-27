using UnityEngine;
using UnityEngine.InputSystem;

public class JumpCheck : MonoBehaviour
{
    public bool groundHit;
    private bool _groundHit;
    public float jumpForce = 8f;
    public Rigidbody2D _rigidbody2D;
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            groundHit = true;
            print("true");
        }
    }

    private void Update()
    {
        if (groundHit && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
            groundHit = false;
        }
    }
}
