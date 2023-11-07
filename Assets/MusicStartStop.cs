using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStartStop : MonoBehaviour
{
    // Start is called before the first frame update

    
    public AudioSource music;

    private void OnTriggerEnter(Collider other)
    {
        music.Pause();        
    }

    private void OnTriggerExit(Collider other)
    {        
        music.Play();
    }
}
