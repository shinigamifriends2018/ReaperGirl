using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text2 : Text1 {

    public Text3 m_text3;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (m_checker == 1)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                m_check = false;
                m_text[1].SetActive(m_check);
                m_check = true;
                m_text[2].SetActive(m_check);
                m_text[3].SetActive(m_check);
                m_checker = 2;
            }
        }
        else if (m_checker == 2){
            if (Input.GetKeyDown(KeyCode.Return))
            {
                m_check = false;
                m_text[2].SetActive(m_check);
                m_text[3].SetActive(m_check);
                m_checker = 3;
                Time.timeScale = 1;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "sinigami")
        {
            m_check = false;
            m_text[0].SetActive(m_check);
            if (m_checker == 0)
            {
                m_text3.m_enemyCheck = true;
                m_check = true;
                m_text[1].SetActive(m_check);
                m_text[4].SetActive(m_check);
                m_text[5].SetActive(m_check);
                m_text[6].SetActive(m_check);
                m_checker = 1;
                Time.timeScale = 0;
            }
        }

    }
}
