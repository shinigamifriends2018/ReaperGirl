using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinigamiController : MonoBehaviour {

    [SerializeField]
    float m_moveSpeed = 4f;
    [SerializeField]
    float m_jumpPower = 5f;
    Vector2 scale;
    Rigidbody2D rb;
    bool m_toConnectHands;

    //  [SerializeField]
    //   Transform m_syoujo;
    Vector2 m_shinigamisPos;

    // Use this for initialization
    void Start () {
        scale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
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
            
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * m_jumpPower, ForceMode2D.Impulse);
        }

 /*       if (Input.GetButtonDown("ConnectHands"))
        {
            if(m_toConnectHands == true)
            {
                gameObject.transform.parent = m_syoujo;
            }
        }       
*/
        transform.localScale = scale;
	}
  /*  private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "syoujo")
        {
            m_toConnectHands = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "syoujo")
        {
            m_toConnectHands = false;
        }
    }
    */
    public Vector2 Posinvestigate
    {
        get
        {
            return m_shinigamisPos;
        }
    }
}
