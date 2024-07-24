using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class PostRequest : MonoBehaviour
{
    private const string url = "https://api.example.com/submit"; // Замість цього URL використовуйте справжній URL вашого API

    void Start()
    {
        StartCoroutine(PostData());
    }

    IEnumerator PostData()
    {
        MyData data = new MyData
        {
            name = "John Doe",
            value = 42
        };

        string json = JsonUtility.ToJson(data);

        using (UnityWebRequest www = new UnityWebRequest(url, "POST"))
        {
            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);
            www.uploadHandler = new UploadHandlerRaw(bodyRaw);
            www.downloadHandler = new DownloadHandlerBuffer();
            www.SetRequestHeader("Content-Type", "application/json");

            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Відповідь від сервера: " + www.downloadHandler.text);
            }
            else
            {
                Debug.LogError("Помилка запиту: " + www.error);
            }
        }
    }
}
