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
        //v�po�et rot�cie kamery pre poh�ad hore a dolu
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //aplikujeme to na transform�ciu na�ej kamery
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //oto�enie hr��a tak, aby sa pozrel do�ava a doprava
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity); 
    }
}
