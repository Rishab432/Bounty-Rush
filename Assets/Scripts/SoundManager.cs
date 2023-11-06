using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource _bgmSource, _sfxSource;
    [SerializeField] private AudioClip _clip;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        _bgmSource.loop = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _sfxSource.PlayOneShot(_clip);
        }
    }

    public void ChangeBGMVolume(float value)
    {
        _bgmSource.volume = value;
    }

    public void ChangeSFXVolume(float value)
    {
        _sfxSource.volume = value;
    }

    public void ToggleSFX()
    {
        _sfxSource.mute = !_sfxSource.mute;
    }

    public void ToggleBGM()
    {
        _bgmSource.mute = !_bgmSource.mute;
    }
}
