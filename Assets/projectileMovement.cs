using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileMovement : MonoBehaviour
{
    
    public float speed = 0.5f;
    SpriteRenderer m_SpriteRenderer;
    BoxCollider2D m_BoxCollider;


    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void DestroyGameObject()
    {
        Destroy(m_SpriteRenderer);
        Destroy(m_BoxCollider);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DestroyGameObject();
        Destroy(GetComponent<BoxCollider>());
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
