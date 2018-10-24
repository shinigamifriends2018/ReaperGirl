using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text3 : Text1 {

    private bool m_enemyDesCheck = true;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if(m_enemyCheck == true)
        {
            if (GameObject.FindWithTag("akuryou") == null || GameObject.FindWithTag("akuryou2") == null || GameObject.FindWithTag("akuryou3") == null)
            {
                if (m_enemyDesCheck == true)
                {
                    Time.timeScale = 0;

                    if (m_checker == 0)
                    {
                        m_check = true;
                        m_text[0].SetActive(m_check);
                        m_text[1].SetActive(m_check);

                        if (Input.GetKeyDown(KeyCode.Return))
                        {
                            m_check = false;
                            m_text[0].SetActive(m_check);
                            m_text[1].SetActive(m_check);
                            m_check = true;
                            m_text[2].SetActive(m_check);
                            m_checker = 1;
                        }
                    }
                    else if (m_checker == 1)
                    {
                        if (Input.GetKeyDown(KeyCode.Return))
                        {
                            m_check = false;
                            m_text[2].SetActive(m_check);
                            m_check = true;
                            m_text[3].SetActive(m_check);
                            m_checker = 2;
                        }
                    }
                    else if (m_checker == 2)
                    {
                        if (Input.GetKeyDown(KeyCode.Return))
                        {
                            m_check = false;
                            m_text[3].SetActive(m_check);
                            m_checker = 3;
                            Time.timeScale = 1;
                            m_enemyDesCheck = false;
                        }
                    }
                }

            }
        }


    }
    
}
