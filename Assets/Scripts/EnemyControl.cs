using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    float speedx;
    float speedy;


    // Start is called before the first frame update
    void Start()
    {
        speedx = 2f;
        speedy = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        position = new Vector2(position.x - speedx * Time.deltaTime, position.y - speedy * Time.deltaTime);

        transform.position = position;

      //  Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        if (transform.position.x < -4.4)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.tag == "PlayerShipTag") || (col.tag == "PlayerBulletTag"))
        {
            Destroy(gameObject);
        }

    }
}