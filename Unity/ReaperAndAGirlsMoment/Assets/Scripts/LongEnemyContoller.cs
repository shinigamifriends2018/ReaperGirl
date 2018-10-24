using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongEnemyContoller : MonoBehaviour {
    [SerializeField]
    GameObject m_heart;

    [SerializeField]
    GameObject m_dawkShute;

    [SerializeField]
    Transform m_ShutePosition;

    private int m_enemyHP = 2;
    private float m_shutePower = 4.5f;
    float m_ChuteCount = 0;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        //Instantiate(m_dawkShute, m_ShutePosition.transform.position, m_ShutePosition.rotation);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("sinigami"))
        {
            --m_enemyHP;
            if (m_enemyHP == 0)
            {
                Destroy(this.gameObject,0.3f);
                Instantiate(m_heart, transform.position, transform.rotation);
            }
        }
    }
}
