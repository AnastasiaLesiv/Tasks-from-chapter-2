using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorReceiver : MonoBehaviour
{
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Метод, який буде викликано UnityEvent
    public void ChangeColor()
    {
        _renderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
