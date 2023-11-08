using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    [SerializeField] private Rigidbody2D _rb2D;

    private Vector2 _movement;

    void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        _rb2D.MovePosition(_rb2D.position + _movement * _speed * Time.fixedDeltaTime);
    }
}
