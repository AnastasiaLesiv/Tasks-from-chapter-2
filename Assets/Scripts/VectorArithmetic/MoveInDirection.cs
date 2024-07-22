using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInDirection : MonoBehaviour
{
    
    public float speed = 5f;

    public Vector3 direction = new Vector3(1, 0, 0); 
    // Start is called before the first frame update
    void Start()
    {
        direction = direction.normalized;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + direction * speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
