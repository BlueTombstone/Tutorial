using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStartController : MonoBehaviour
{
    private bool isSceneStarted = false;
    public GameObject StartText;
    [SerializeField] float _difficulty = 0f;

    void Start()
    {
        Time.timeScale = 0;
        StartText.SetActive(true);
    }

    void Update()
    {
        if (!isSceneStarted && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            isSceneStarted = true;
            Debug.Log("Input detected. Starting scene...");
            StartScene();
        }
    }

    void StartScene()
    {
        Debug.Log("Scene is starting now!");
        Time.timeScale = _difficulty;
        StartText.SetActive(false);

        // Add your scene start logic here, such as enabling certain GameObjects or starting a timer, etc.
    }
}
