using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer : MonoBehaviour
{
    private float mouseX, mouseY;

    public float mousSpeed = 100;

    public Transform player;

    public float xRotation;

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mousSpeed * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mousSpeed * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -70, 70);

        player.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}
