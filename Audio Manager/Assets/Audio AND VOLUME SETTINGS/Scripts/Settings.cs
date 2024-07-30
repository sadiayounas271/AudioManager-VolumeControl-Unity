using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] VolumeControl soundControl;
    [SerializeField] VolumeControl musicControl;

    public static Settings Instance; 
    public void Initialize()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        soundControl.Initialize();
        musicControl.Initialize();
        DontDestroyOnLoad(this);
    }

    public void EnableSettingsPanel()
    {
        gameObject.SetActive(true);
    }
}
