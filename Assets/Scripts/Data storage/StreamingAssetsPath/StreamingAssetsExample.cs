using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class StreamingAssetsExample : MonoBehaviour
{
    private string fileName = "randomNumber.txt";

    void Start()
    {
        // Збереження випадкового числа у файл
        SaveRandomNumberToFile();

        // Завантаження числа з файлу
        string data = LoadFromFile();
        Debug.Log("Loaded Data: " + data);
    }

    // Метод для збереження випадкового числа у файл
    void SaveRandomNumberToFile()
    {
        // Генерація випадкового числа
        int randomNumber = Random.Range(0, 100);
        string data = randomNumber.ToString();

        // Створення шляху до файлу
        string path = Path.Combine(Application.streamingAssetsPath, fileName);

        // Запис числа у файл
        File.WriteAllText(path, data);

        Debug.Log("Random number saved to: " + path);
    }
    // Метод для завантаження числа з файлу
    string LoadFromFile()
    {
        // Створення шляху до файлу
        string path = Path.Combine(Application.streamingAssetsPath, fileName);

        if (File.Exists(path))
        {
            // Читання числа з файлу
            return File.ReadAllText(path);
        }
        else
        {
            Debug.LogWarning("File not found: " + path);
            return null;
        }
    }
}
