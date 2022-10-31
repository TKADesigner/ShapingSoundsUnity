using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb;
    AudioSource aud;
    private float newPlayTimer = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        aud = GetComponent<AudioSource>();
        float startingVelocityX = Random.Range(-5, 5);
        float startingVelocityY = Random.Range(-5, 5);
        Vector2 startingVelocity = new Vector2(startingVelocityX, startingVelocityY).normalized;
        rb.velocity = startingVelocity * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (newPlayTimer > 0.2)
        {
            aud.Play();
            newPlayTimer = 0;
        }
    }
    private void Update()
    {
        newPlayTimer += Time.deltaTime;
        if (rb.velocity.magnitude != speed)
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
    }
}
