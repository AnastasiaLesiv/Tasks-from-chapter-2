using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPrefabExample : MonoBehaviour
{
    void Start()
    {
        GameObject prefab = Resources.Load<GameObject>("Assets/Easy Primitive Animals/FarmEdition/Prefabs/Props/Trough_large.prefab");
        if (prefab != null)
        {
            Instantiate(prefab, Vector3.zero, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Prefab not found!");
        }
    }
}
