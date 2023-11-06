using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXSlider : MonoBehaviour
{
    [SerializeField] private Slider _sfxSlider;

    void Start()
    {
        SoundManager.Instance.ChangeSFXVolume(_sfxSlider.value);
        _sfxSlider.onValueChanged.AddListener(sfxVal => SoundManager.Instance.ChangeSFXVolume(sfxVal));
    }
}
