using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemyController : GhostController {

    [SerializeField]
    int m_enemyHP = 2;

    // Use this for initialization
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        base.Patrol();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Wall"))
        {
            Vector2 scale = gameObject.transform.localScale;
            scale.x *= -1f;
            gameObject.transform.localScale = scale;
        }
        if (collision.gameObject.tag == (""))//鎌に当たるとダメージ
        {
            --m_enemyHP;
        }
    }
}
