using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAudioClipExample : MonoBehaviour
{
    void Start()
    {
        AudioClip clip = Resources.Load<AudioClip>("Assets/UnityTechnologies.Raycast/Shared Assets/Audio/ShooterWeapon.aif");
        if (clip != null)
        {
            GetComponent<AudioSource>().clip = clip;
            GetComponent<AudioSource>().Play();
        }
        else
        {
            Debug.LogError("Audio clip not found!");
        }
    }
}
