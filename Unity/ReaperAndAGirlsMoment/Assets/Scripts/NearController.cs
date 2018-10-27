﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearController : MonoBehaviour{

    public int m_enemyHP = 2;
    public GameObject m_testmove;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (m_enemyHP == 0)
        {
            TestMove testMove = m_testmove.GetComponent<TestMove>();
            testMove.m_returnCheck = true;
            Destroy(this.gameObject, 0.3f);
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("sinigami"))
        {
            --m_enemyHP;
        }
    }
}
