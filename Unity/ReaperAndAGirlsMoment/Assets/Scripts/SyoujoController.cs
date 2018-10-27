﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SyoujoController : CharacterBase
{
    int m_aFeelingOfBelieve = 3;
    bool m_followMode;
    [SerializeField]
    ShinigamiController shinigami;

    // Use this for initialization

    void Start()
    {
        base.m_moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
       if(m_aFeelingOfBelieve >= 3)
        {
            m_followMode = true;
        }
        else
        {
            m_followMode = false;
        }
        if (m_followMode == true)
        {
            if (shinigami.Posinvestigate.x > transform.position.x)
            {
                Move();
            }
            else if (shinigami.Posinvestigate.x < transform.position.x)
            {
                transform.Translate(new Vector2(-m_moveSpeed * Time.deltaTime, 0f));
            }
        }
    }
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if(m_followMode == true)
        {

        }
    }
    */
}
