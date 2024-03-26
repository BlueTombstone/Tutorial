using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BGMusicScript : MonoBehaviour
{
    private AudioSource _bgMusic;


    void Start()
    {
        _bgMusic = GetComponent<AudioSource>();
    }

   
}
