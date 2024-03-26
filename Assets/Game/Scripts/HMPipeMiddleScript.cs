using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMPipeMiddleScript : MonoBehaviour
{
    public HiddenHiScoreScript score;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<HiddenHiScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            score.addScore(1);
        }
        
    }
}
