using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinigamiController : CharacterBase {

    Vector2 scale;
    Rigidbody2D rb;
    bool m_toConnectHands;
    bool m_onAttack = false;
    [SerializeField]
    GameObject m_sickle;
    [SerializeField]
    SyoujoController syoujo;
    float m_interval = 0.2f;



    Vector2 m_shinigamisPos;

    // Use this for initialization
    void Start () {
        m_simpleAnimation = GetComponent<SimpleAnimation>();
        scale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        m_jumpPower = 10.5f;
    }

	// Update is called once per frame
	void Update () {
        if(syoujo.ConnectHandsTF == false)
        {
            m_moveSpeed = 4.0f;
        }
        else
        {
            m_moveSpeed = 4.5f;
        }

        m_shinigamisPos = gameObject.transform.position;
        float h = Input.GetAxisRaw("Horizontal");
        transform.Translate(new Vector2(m_moveSpeed * h * Time.deltaTime, 0f));
        if(h > 0)
        {
            if (scale.x < 0)
            {
                scale.x *= -1f;
            }
        } else if(h < 0)
        {
            if (scale.x > 0)
            {
                scale.x *= -1f;
            }
        }

        if (Input.GetButtonDown("S"))
        {
            Fall();
        }
        if (Input.GetButtonDown("Jump"))
        {
            Jump(rb);
        }
        if (Input.GetButtonDown("Attack"))
        {
            Attack();  
        }
		else if (m_onAttack == false)
		{
			m_simpleAnimation.CrossFade("Idle", m_interval);
		}
        if (Input.GetButtonDown("ConnectHands"))
        {
            if (syoujo.ConnectHandsTF == false)
            {
                if (m_toConnectHands == true)
                {
                    syoujo.OnConnectHands = true;
                }
            }
            else
            {
                syoujo.OnConnectHands = false;
            }
        }       

        transform.localScale = scale;
       
           
               
              
      
	}

    void Attack()
    {
        if (m_onAttack == false)
        {
            if(syoujo.ConnectHandsTF == true)
            {
                syoujo.OnConnectHands = false;
            }

            m_sickle.SetActive(true);
            if (m_jump == false)
            {
                m_onAttack = true;
				m_simpleAnimation.CrossFade("JumpAttack", 0.05f);
            }
            else
            {
                m_onAttack = true;
                m_simpleAnimation.CrossFade("Attack", 0.05f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            m_jump = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "syoujo")
        {
            m_toConnectHands = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "syoujo")
        {
            m_toConnectHands = false;
        }
    }

    public void OnAnimationFinished()
    {
        {
            m_sickle.SetActive(false);
            Invoke("Interval", m_interval+0.1f);
			m_simpleAnimation.CrossFade("Idle", m_interval);

        }
    }

    void Interval()
    {
        m_onAttack = false;
    }

    public Vector2 Posinvestigate
    {
        get
        {
            return m_shinigamisPos;
        }
    }
}
