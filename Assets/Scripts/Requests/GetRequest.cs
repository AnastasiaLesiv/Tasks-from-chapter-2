using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class GetRequest : MonoBehaviour
{
    private const string url = "https://api.example.com/data"; // Замість цього URL використовуйте справжній URL вашого API

    void Start()
    {
        StartCoroutine(GetData());
    }

    IEnumerator GetData()
    {
        using (UnityWebRequest www = UnityWebRequest.Get(url))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
            {
                // Обробка відповіді
                Debug.Log("Отримані дані: " + www.downloadHandler.text);

                // Десеріалізація JSON
                MyData data = JsonUtility.FromJson<MyData>(www.downloadHandler.text);
                Debug.Log("Отримані дані: " + data.name);
            }
            else
            {
                Debug.LogError("Помилка запиту: " + www.error);
            }
        }
    }
}

[System.Serializable]
public class MyData
{
    public string name;
    public int value;
}