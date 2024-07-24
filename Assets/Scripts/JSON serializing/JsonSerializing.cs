using System.IO;
using UnityEngine;

public class JsonSerializing: MonoBehaviour
{
    public PlayerData playerData;

    void Start()
    {
        playerData = new PlayerData();
        playerData.playerName = "John";
        playerData.playerScore = 100;
        playerData.playerPosition = new Vector3(1.0f, 2.0f, 3.0f);

        SaveToJson();
    }

    void SaveToJson()
    {
        // Перетворення об'єкта в JSON-рядок
        string json = JsonUtility.ToJson(playerData);

        // Шлях до файлу в StreamingAssets
        string path = Path.Combine(Application.streamingAssetsPath, "playerData.json");

        // Запис JSON у файл
        File.WriteAllText(path, json);

        Debug.Log("Дані збережено у файл: " + path);
    }
}
