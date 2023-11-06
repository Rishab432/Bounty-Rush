using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _bgmSlider;

    void Start()
    {
        SoundManager.Instance.ChangeBGMVolume(_bgmSlider.value);
        _bgmSlider.onValueChanged.AddListener(bgmVal => SoundManager.Instance.ChangeBGMVolume(bgmVal));
    }
}
