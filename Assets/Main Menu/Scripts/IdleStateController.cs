using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IdleStateController : MonoBehaviour
{
    private Animator animator;
    public string Hidden; // Name of the specific scene where you want to change idle state

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the current scene is the specific scene where you want to change idle state
        if (SceneManager.GetActiveScene().name == Hidden)
        {
            animator.SetBool("hiddenScene", true); // Set custom idle state
        }
        else
        {
            animator.SetBool("hiddenScene", false); // Set default idle state
        }
    }
}
