using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPressScript : MonoBehaviour
{
    public LogicScript logic;
    private Button button;
    

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
        
    }

    void OnButtonClick()
    {
        Debug.Log("Button clicked!");
        restartGame();
        // Add your button click logic here
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar pressed!");
            restartGame();
            // Add your spacebar input logic here
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
