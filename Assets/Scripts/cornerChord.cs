using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class cornerChord : MonoBehaviour
{
    public bool top;
    public bool left;
    AudioSource aud;
    public Animator animator;
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.zero;
        Vector3 screenCoords = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        if (top)
        {
            pos.y += screenCoords.y;
        } else
        {
            pos.y -= screenCoords.y;
        }
        if (left)
        {
            pos.x += screenCoords.x;
        } else
        {
            pos.x -= screenCoords.x;
        }
        transform.position = pos;
        if (Input.GetKeyDown("y")) {
            ring();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "shape")
        {
            ring();
        }
    }

    private void ring()
    {
        aud.Play();
        animator.SetTrigger("fade");
    }
}