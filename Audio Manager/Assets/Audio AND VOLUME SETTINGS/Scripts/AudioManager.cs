using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource audioSource_Music;
    public AudioSource audioSource_Sound;

    [Space]

    [SerializeField]
    private AudioClip m_TapSound, m_PurchaseSound, m_HitSound, m_WinSound,
    m_MainMusic, m_GamePlayMusic;

    public void Initialize()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public enum SoundType
    {
        TapSound,
        PurchaseSound,
        HitSound,
        WinSound,

        BgMusicMain,
        BgMusicGamePlay,
    }



    public AudioClip GetAudioClip(SoundType soundType)
    {
        return soundType switch
        {
            SoundType.TapSound => m_TapSound,
            SoundType.PurchaseSound => m_PurchaseSound,
            SoundType.HitSound => m_HitSound,
            SoundType.WinSound => m_WinSound,


            SoundType.BgMusicMain => m_MainMusic,
            SoundType.BgMusicGamePlay => m_GamePlayMusic,

            _ => throw new NotImplementedException(),
        };
    }
    public void PlayMusic(SoundType music)
    {
        AudioClip _audioClip = GetAudioClip(music);
        audioSource_Music.clip = _audioClip;
        audioSource_Music.Play();
    }


    public void PlaySound(SoundType sound)
    {
        if (PlayerPrefs.GetFloat(nameof(SoundOrMusic.Sound)) <= 0.001f)
        {
            return;
        }

        AudioClip _audioClip = GetAudioClip(sound);
        audioSource_Sound.clip = _audioClip;
        audioSource_Sound.Play();
    }
}
