using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SyoujoController : MonoBehaviour
{
    [SerializeField]
    float m_moveSpeed = 3f;
    int m_aFeelingOfBelieve = 3;
    bool m_followMode;
    [SerializeField]
    ShinigamiController shinigami;


    // Use this for initialization

    void Start()
    {
        
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
                transform.Translate(new Vector2(m_moveSpeed * Time.deltaTime, 0f));
            }
            else if (shinigami.Posinvestigate.x < transform.position.x)
            {
                transform.Translate(new Vector2(-m_moveSpeed * Time.deltaTime, 0f));
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(m_followMode == true)
        {

        }
    }
}
