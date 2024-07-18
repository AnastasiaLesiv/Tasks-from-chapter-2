using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EulerRotation : MonoBehaviour
{
    public float rotationSpeed = 360f;
    Vector3 currentEulerAngles;

    float rotationX;
    float rotationY;
    float rotationZ;


    void Update()
    {
        
        if ( Input.GetKeyDown ( KeyCode.X )) rotationX = 1 - rotationX;
        if ( Input.GetKeyDown ( KeyCode.Y )) rotationY = 1 - rotationY;
        if ( Input.GetKeyDown ( KeyCode.Z )) rotationZ = 1 - rotationZ; 

       
        currentEulerAngles += new Vector3 (rotationX, rotationY, rotationZ) * Time.deltaTime * rotationSpeed; 

        transform.eulerAngles = currentEulerAngles;
    }
}
