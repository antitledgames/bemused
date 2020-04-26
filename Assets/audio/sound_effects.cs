using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_effects : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        audio.clip = soundEffect;
        audio.Play();
    }
}
