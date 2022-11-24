using System;
using UnityEngine;
using UnityEngine.InputSystem;

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

        if (_groundHit || Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
        }
        
        /*if (_input.JumpPressed && (_collision.IsGrounded_Box() || doubleJump > 0))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpSpeed);
            doubleJump--;
        }

        if (_collision.IsGrounded_Box())
        {
            doubleJump = 1;
        }*/
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            _groundHit = true;
            print("true");
        }
        else
        {
            _groundHit = false;
            print("false");
        }
    }
}
