using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text1 : MonoBehaviour {

    public bool m_check = true;
    public bool m_enemyCheck = false;
    public GameObject [] m_text;
    public int m_checker = 0;

    // Use this for initialization
    void Start () {
        m_text[0].SetActive(m_check);
        m_text[1].SetActive(m_check);
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "sinigami")
        {
            m_check = false;
            m_text[1].SetActive(m_check);

            if (m_checker == 0)
            {
                m_checker = 1;
                m_check = true;
                m_text[2].SetActive(m_check);
            }
        }
    }
}
