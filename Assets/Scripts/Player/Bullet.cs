using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private int damage;
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] float timer;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        

        rb.velocity = new Vector2(speed, rb.velocity.y);
        
        timer = Time.deltaTime;
        if (timer >= 3f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy1") || (collision.CompareTag("Enemy2")))
        {
            Destroy(gameObject);
        }
    }
}
