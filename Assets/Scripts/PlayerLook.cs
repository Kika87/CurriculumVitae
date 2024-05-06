using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 8f;
    public float ySensitivity = 8f;
    

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //výpoèet rotácie kamery pre poh¾ad hore a dolu
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //aplikujeme to na transformáciu našej kamery
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //otoèenie hráèa tak, aby sa pozrel do¾ava a doprava
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity); 
    }
}
