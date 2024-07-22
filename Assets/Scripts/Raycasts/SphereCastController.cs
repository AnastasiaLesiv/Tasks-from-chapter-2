using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCastController : MonoBehaviour
{
    public float rayLenght = 10f;

    public float sphereRadius = 1f;

    public LayerMask hitLayers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootSphereCast();
        }
    }

    void ShootSphereCast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.SphereCast(ray, sphereRadius, out hit, rayLenght, hitLayers))
        {
            Debug.Log("Hit object: " + hit.collider.name);
            Debug.DrawLine(ray.origin, hit.point, Color.red, 2.0f);
            DrawSphere(hit.point, sphereRadius, Color.red);
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * rayLenght, Color.green, 2.0f);
            DrawSphere(ray.origin + ray.direction * rayLenght, sphereRadius, Color.green);
        }
    }

    void DrawSphere(Vector3 position, float radius, Color color)
    {
        int segment = 20;
        float angle = 0f;
        float increment = Mathf.PI * 2f / segment;
        Vector3[] points = new Vector3[segment];

        for (int i = 0; i < segment; i++)
        {
            points[i] = position + new Vector3(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius, 0f);
            angle += increment;
        }

        for (int i = 0; i < segment; i++)
        {
            Debug.DrawLine(points[i], points[(i + 1) % segment], color, 2.0f);
        }
    }
}
