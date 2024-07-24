using System.IO;
using UnityEngine;

public class JsonLDeserializing : MonoBehaviour
{
    public PlayerData playerData;

    void Start()
    {
        LoadFromJson();
    }

    void LoadFromJson()
    {
        // Шлях до файлу в StreamingAssets
        string path = Path.Combine(Application.streamingAssetsPath, "playerData.json");

        // Перевірка, чи існує файл
        if (File.Exists(path))
        {
            // Читання JSON з файлу
            string json = File.ReadAllText(path);

            // Перетворення JSON у об'єкт
            playerData = JsonUtility.FromJson<PlayerData>(json);

            Debug.Log("Дані завантажено з файлу: " + path);
            Debug.Log("Ім'я гравця: " + playerData.playerName);
            Debug.Log("Рахунок гравця: " + playerData.playerScore);
            Debug.Log("Позиція гравця: " + playerData.playerPosition);
        }
        else
        {
            Debug.LogError("Файл не знайдено: " + path);
        }
    }
}