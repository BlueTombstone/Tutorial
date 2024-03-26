using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HiddenButtonScript : MonoBehaviour
{
    public string nextSceneName;
    public float delayDuration = 1f;
    public AudioSource buttonSound;
    private Button button;


    void Start()
    {
        
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);

    }

    void OnButtonClick()
    {
        Debug.Log("Button clicked!");
        buttonSound.Play();
        
        StartCoroutine(DelayedSceneTransition());
        // Add your button click logic here
    }

    IEnumerator DelayedSceneTransition()
    {
        yield return new WaitForSeconds(delayDuration);

        SceneManager.LoadScene(nextSceneName);
    }

    
    
}
