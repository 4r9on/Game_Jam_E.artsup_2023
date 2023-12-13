using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera camera;

    CharacterController characterController;

    public float speed;
    public float jump;
    public float gravity;

    float rotationX = 0;
    public float rotationSpeed = 2.0f;
    public float rotationXLimit = 45.0f;

    Vector3 moveDirection;

    private void Start()
    {
        Cursor.visible = false;
        characterController = GetComponent<CharacterController>();  
    }

    private void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        float speedZ = Input.GetAxis("Vertical");
        float speedX = Input.GetAxis("Horizontal");

        moveDirection = forward * speedZ + right * speedX;
    }
}
