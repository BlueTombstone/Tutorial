using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{
    public bool playerIsAlive = true;
    public LogicScript logic;
    private Animator anim;
    private AudioSource deathSound;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        anim = GetComponent<Animator>();
        deathSound = GetComponent<AudioSource>();
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
