﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour {
    [SerializeField]
    protected float m_moveSpeed;
    protected float m_jumpPower;
    protected int m_hitPoint;
    protected SimpleAnimation m_simpleAnimation;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    protected void Move()
    {
        transform.Translate(new Vector2(m_moveSpeed * Time.deltaTime, 0f));
    }
    protected void Jump(Rigidbody2D rb)
    {
        rb.AddForce(Vector2.up * m_jumpPower, ForceMode2D.Impulse);
    }
    protected void Damage()
    {
        m_hitPoint--;
    }
}
