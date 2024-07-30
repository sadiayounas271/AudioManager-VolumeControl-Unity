using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    [SerializeField] Button winSoundButton;
    [SerializeField] Button purchaseSoundButton;
    [Space]
    [SerializeField] Button backButton;
    [SerializeField] Button settingButton;

    private void Awake()
    {
        backButton.onClick.AddListener(BackFunc);
        settingButton.onClick.AddListener(EnableSettingPanel);

        winSoundButton.onClick.AddListener(PlayWinSound);
        purchaseSoundButton.onClick.AddListener(PurchaseSound);
        AudioManager.Instance.PlayMusic(AudioManager.SoundType.BgMusicGamePlay);
    }

    private void PurchaseSound()
    {
        AudioManager.Instance.PlaySound(AudioManager.SoundType.PurchaseSound);
    }

    private void PlayWinSound()
    {
        AudioManager.Instance.PlaySound(AudioManager.SoundType.WinSound);
    }

    private void EnableSettingPanel()
    {
        Settings.Instance.EnableSettingsPanel();
    }

    private void BackFunc()
    {
        SceneManager.LoadScene(0);
    }
}
