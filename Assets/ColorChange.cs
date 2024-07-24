using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorChanger : MonoBehaviour
{
    // Створення UnityEvent
    public UnityEvent OnColorChange;

    void Start()
    {
        // Якщо немає підписників, додаємо стандартну дію
        if (OnColorChange == null)
            OnColorChange = new UnityEvent();
    }

    void Update()
    {
        // При натисканні пробілу викликати подію
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnColorChange.Invoke();
        }
    }
}
