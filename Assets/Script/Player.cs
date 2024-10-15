using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    [SerializeField] float speed = 1000f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

   
    void Update()
    {
        Vector3 scale = transform.localScale;

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed * Time.deltaTime, 0);
            scale.x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed * Time.deltaTime, 0);
            scale.x = 1;
        }

        animator.SetBool("IsWalking", true);
        transform.localScale = scale;

        if (Mathf.Abs(rb.velocity.x) < 0.5)
        {
            animator.SetBool("IsWalking", false);
        }
    }
}
