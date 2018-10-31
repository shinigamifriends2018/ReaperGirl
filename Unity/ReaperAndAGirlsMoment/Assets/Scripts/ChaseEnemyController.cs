using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseEnemyController : GhostController{

    [SerializeField]
    int m_enemyHP = 2;
    [SerializeField]
    GameObject m_tutorialToriger;
    bool m_syoujoCheck = false;
    Renderer m_renderer;
    [SerializeField]
    bool m_tutorialEnemyCheck; 
    // Use this for initialization
    void Start () {
        m_renderer = GetComponent<Renderer>();
        m_renderer.enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 syoujoPos = m_syoujo.transform.position;
        Vector2 akuryouPos = m_akuryou.transform.position;
        if (akuryouPos.x - syoujoPos.x <= 5 && akuryouPos.x - syoujoPos.x >= -5)
        {
            m_renderer.enabled = true;
            m_syoujoCheck = true;
        }
        if(m_syoujoCheck == true)
        {
            base.Chase();
        }
        if(m_tutorialEnemyCheck == true)
        {
            m_renderer.enabled = true;
            m_syoujoCheck = true;
        }
        if (m_enemyHP == 0)
        {
            TutorialToriger tutorialToriger = m_tutorialToriger.GetComponent<TutorialToriger>();
            tutorialToriger.m_returnCheck = true;
            Destroy(this.gameObject, 0.3f);
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Sickle"))//鎌に当たるとダメージ
        {
            --m_enemyHP;
        }
    }
   

}
