using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_script : MonoBehaviour
{
    public List<AudioClip> otherClips;
    public List<AudioClip> hints;
    public AudioSource audio;
    public float delay;
    private bool finished = false;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        foreach (AudioClip otherClip in otherClips) {
            yield return new WaitForSeconds(delay);
            audio.clip = otherClip;
            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
        }
        finished = true;
    }

    IEnumerator hintz()
    {
        finished = false;
        yield return new WaitForSeconds(150);
        audio.clip = hints[Random.Range(0, 3)];
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        finished = true;
    
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
        {
            StartCoroutine("hintz", 0.0f);
        }
    }
}
