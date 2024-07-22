using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PersistentDataPathExample : MonoBehaviour
{
    private string fileName = "saveData.json";

    // Дані для збереження
    [System.Serializable]
    public class SaveData
    {
        public int playerScore;
        public string playerName;
    }

    void Start()
    {
        SaveData data = new SaveData();
        data.playerScore = 100;
        data.playerName = "JohnDoe";

        SaveToFile(data);
        LoadFromFile();
    }
    // Збереження даних у файл
    void SaveToFile(SaveData data)
    {
        string json = JsonUtility.ToJson(data);
        string path = Path.Combine(Application.persistentDataPath, fileName);

        File.WriteAllText(path, json);

        Debug.Log("Data saved to: " + path);
    }

    // Завантаження даних з файлу
    void LoadFromFile()
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            Debug.Log("Data loaded from: " + path);
            Debug.Log("Player Name: " + data.playerName);
            Debug.Log("Player Score: " + data.playerScore);
        }
        else
        {
            Debug.LogWarning("Save file not found: " + path);
        }
    }
}
