using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    public int bounceCount = 0;

    public float distanceToFloor = 0;

    public LayerMask floorLayer;

    private Rigidbody rb;

    private float sphereRadius;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SphereCollider sphereCollider = GetComponent<SphereCollider>();
        sphereRadius = sphereCollider.radius * transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, Mathf.Infinity, floorLayer))
        {
            distanceToFloor = hit.distance - sphereRadius;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            bounceCount++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Ball passed through the obstacle.");
        }
    }
}
