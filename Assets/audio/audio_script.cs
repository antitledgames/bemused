using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audio_script : MonoBehaviour
{
    public GameObject luminitaPC, luminitaTelefon;
    public List<AudioClip> otherClips;
    public List<AudioClip> hints;
    public AudioSource audio;
    public float delay;
    private bool finished = false;

    IEnumerator Start()
    {
        bool isGianni=true;
        foreach (AudioClip otherClip in otherClips) {
            yield return new WaitForSeconds(delay);
            audio.clip = otherClip;
            if (isGianni)
            {
               
                isGianni = false;
            }
            else
            {
                luminitaTelefon.SetActive(true);
                isGianni = true;
            }
            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            luminitaPC.SetActive(false);
            luminitaTelefon.SetActive(false);
           
        }
        finished = true;
    }

    IEnumerator hintz()
    {
        finished = false;
        yield return new WaitForSeconds(150);
        audio.clip = hints[Random.Range(0, 3)];
        luminitaTelefon.SetActive(true);
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        luminitaTelefon.SetActive(false);
        finished = true;
    
    }

    void Update()
    {
        if (finished)
        {
            StartCoroutine("hintz", 0.0f);
        }
    }

}
