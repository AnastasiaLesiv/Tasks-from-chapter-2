using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionRotation : MonoBehaviour
{
    public float rotationSpeed = 360f;
    
    private float rotationX;
    private float rotationY;
    private float rotationZ;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) rotationX = 1 - rotationX;
        if (Input.GetKeyDown(KeyCode.Y)) rotationY = 1 - rotationY;
        if (Input.GetKeyDown(KeyCode.Z)) rotationZ = 1 - rotationZ;

        float rotationAmount = rotationSpeed * Time.deltaTime;
        
        Quaternion rotationChange = Quaternion.Euler(rotationX * rotationAmount, rotationY * rotationAmount, rotationZ * rotationAmount);
        
        transform.rotation = transform.rotation * rotationChange;
    }
}
