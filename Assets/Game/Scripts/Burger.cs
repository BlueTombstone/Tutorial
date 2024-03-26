using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength;
    public LogicScript logic;
    public bool playerIsAlive = true;
    public bool isFalling = false;
    private Animator anim;
    private AudioSource deathSound;
    [SerializeField] float flapAngle = 0;

    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        anim = GetComponent<Animator>();
        deathSound = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) && playerIsAlive)
        {
            rb.velocity = Vector2.up * flapStrength;
            
        }

    }

    void FixedUpdate()
    {

        if (rb.velocity.y < 0 && !isFalling && playerIsAlive)
        {
            isFalling = true;
            transform.rotation = Quaternion.identity;
            // anim.Play("BurgerIdle");
        }
        else if (rb.velocity.y >= 0 && isFalling && playerIsAlive)
        {
            isFalling = false;
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle - flapAngle);
            //anim.Play("BurgerJump");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        playerIsAlive = false;
        deathSound.Play();
        anim.Play("BurgerDestroy");
        Destroy(gameObject, 0.5f);
    }
}
