using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Image _healthBar;
    [SerializeField] private float _healthAmount = 100f;
    private const float _damage = 10f;


    public void TakeDamage()
    {
        _healthAmount -= _damage;
        _healthBar.fillAmount = _healthAmount / 100f;
    }
}
