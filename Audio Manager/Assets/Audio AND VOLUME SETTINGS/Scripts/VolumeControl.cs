using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public enum SoundOrMusic
{
    Music,
    Sound  
}
public class VolumeControl : MonoBehaviour
{
    [SerializeField] SoundOrMusic _volumeParameter;
    [SerializeField] AudioMixer _mixer;
    [SerializeField] Slider _slider;
    [SerializeField] float _multiplier = 30f;

    [SerializeField] Toggle _toggle;

    public void Initialize()
    {
        _toggle.onValueChanged.AddListener(HandleToggleChangedValue);
        _slider.onValueChanged.AddListener(HandleSliderChangedValue);
        SetSoundAndMusicOnGameStart();
    }

    private void HandleToggleChangedValue(bool isEnabled)
    {
        if (_disableToggleEvent == false)
        {
            if (isEnabled)
            {
                _slider.value = _slider.maxValue;
            }
            else
            {
                _slider.value = _slider.minValue;
            }
        }
    }

    private bool _disableToggleEvent = false;

    private void HandleSliderChangedValue(float value)
    {
        _mixer.SetFloat(_volumeParameter.ToString(), Mathf.Log10(value) * _multiplier);
        _disableToggleEvent = true;
        _toggle.isOn = _slider.value > _slider.minValue; // Dont call Toggler Event on enabling/disabling from here
        _disableToggleEvent = false;

        if (_volumeParameter == SoundOrMusic.Music)
        {
            if (!_toggle.isOn)
            {
                AudioManager.Instance.audioSource_Music.mute = true;
            }
            else
            {
                AudioManager.Instance.audioSource_Music.mute = false;
            }
        }
        
    }
    private void OnDisable()
    {
        PlayerPrefs.SetFloat(_volumeParameter.ToString(), _slider.value);
    }
    private void SetSoundAndMusicOnGameStart()
    {
        _slider.value = PlayerPrefs.GetFloat(_volumeParameter.ToString());
        HandleSliderChangedValue(_slider.value);
    }
}
