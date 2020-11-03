using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Joystick joystick;
    public float joystickSensitivity;
    public float horizontalForce;
    public float jumpForce;
    public float maximumVelocityX;
    public Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
    }

    private void _Move()
    {
        if (joystick.Horizontal > joystickSensitivity)
        {
            //move to right
            rigidBody2D.AddForce(Vector2.right * horizontalForce * Time.deltaTime);
        }

        if (joystick.Horizontal < -joystickSensitivity)
        {
            //move to left
            rigidBody2D.AddForce(Vector2.left* horizontalForce * Time.deltaTime);
        }
    }
}
