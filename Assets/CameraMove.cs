using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f; // Camera movement speed
    public float sensitivityX = 2f; // Mouse sensitivity for horizontal rotation

    private void Update()
    {
        // Camera movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized * moveSpeed * Time.deltaTime;
        transform.Translate(moveDirection);

        // Camera rotation
        float mouseX = Input.GetAxis("Mouse X") * sensitivityX;

        transform.Rotate(Vector3.up * mouseX);
    }
}