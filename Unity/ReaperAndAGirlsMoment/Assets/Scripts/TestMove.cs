using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour {

    public float m_walk = 2f;
    bool m_mooveCheck = true;
	// Use this for initialization
	void Start () {


    }

    // Update is called once per frame
    void Update () {

        Vector2 scale = transform.localScale;
        Vector2 pos = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            scale.x = -1f;
            transform.Translate(new Vector2(m_walk * Time.deltaTime, 0f));

        }
        if (Input.GetKey(KeyCode.A))
        {
            scale.x = 1f;
            transform.Translate(new Vector2(-m_walk * Time.deltaTime, 0f));

        }
        transform.localScale = scale;
    }
}
