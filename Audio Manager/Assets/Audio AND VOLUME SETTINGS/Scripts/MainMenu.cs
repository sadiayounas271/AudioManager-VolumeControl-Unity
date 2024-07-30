using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button hitButton;
    [SerializeField] Button tapButton;
    [SerializeField] Button settingButton;
    [SerializeField] Button nextSceneButton;

    //[SerializeField] GameObject settingPanel;
    [SerializeField] AudioManager audioManager;
    [SerializeField] Settings settings;

    private void Awake()
    {
        GameStart();
    }
    void GameStart()
    {
        audioManager.Initialize();
        settings.Initialize();
        nextSceneButton.onClick.AddListener(LoadNextScene);
        hitButton.onClick.AddListener(HitButtonFunc);
        tapButton.onClick.AddListener(TapButtonFunc);
        settingButton.onClick.AddListener(EnableSettingButton);
        Invoke(nameof(PlayMainSceneMusic), 0.1f);
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
    void PlayMainSceneMusic()
    {
        AudioManager.Instance.PlayMusic(AudioManager.SoundType.BgMusicMain);
    }

    private void TapButtonFunc()
    {
        AudioManager.Instance.PlaySound(AudioManager.SoundType.TapSound);
    }

    private void EnableSettingButton()
    {
        Settings.Instance.EnableSettingsPanel();
    }

    private void HitButtonFunc()
    {
        AudioManager.Instance.PlaySound(AudioManager.SoundType.HitSound);
    }
}
