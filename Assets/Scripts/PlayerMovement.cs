using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField] private VariableJoystick _movementJoystic;
    [SerializeField] private VariableJoystick _rotationJoystic;
    [SerializeField] private Camera _maninCamera;
    [SerializeField] private float _sensitivity;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        PlayerMove();
        PlayerRotate();


    }
   void PlayerMove()
    {
        Vector3 direction = transform.forward * _movementJoystic.Vertical + transform.right * _movementJoystic.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
    void PlayerRotate()
    {
            transform.Rotate(new Vector3(0, _rotationJoystic.Horizontal, 0) * Time.deltaTime * _sensitivity);
    }
   
}