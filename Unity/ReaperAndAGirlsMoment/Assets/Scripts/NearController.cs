using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearController : MonoBehaviour{

    private int m_enemyHP = 2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("sinigami"))
        {
            --m_enemyHP;
            if (m_enemyHP == 0)
            {
                Destroy(this.gameObject,0.3f);
            }
        }
    }
}
