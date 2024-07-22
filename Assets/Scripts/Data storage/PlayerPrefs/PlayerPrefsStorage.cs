using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsStorage : MonoBehaviour
{
    void Start()
    {
        // Збереження даних
        PlayerPrefs.SetString("PlayerName", "JohnDoe");
        PlayerPrefs.SetInt("PlayerScore", 100);
        PlayerPrefs.Save(); // Збереження змін

        // Завантаження даних
        string playerName = PlayerPrefs.GetString("PlayerName", "Unknown");
        int playerScore = PlayerPrefs.GetInt("PlayerScore", 0);

        Debug.Log("Player Name: " + playerName);
        Debug.Log("Player Score: " + playerScore);
    }

    void Update()
    {
        // Збереження нових даних при натисканні пробілу
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScore") + 10);
            PlayerPrefs.Save();
            Debug.Log("New Player Score: " + PlayerPrefs.GetInt("PlayerScore"));
        }
    }
}
