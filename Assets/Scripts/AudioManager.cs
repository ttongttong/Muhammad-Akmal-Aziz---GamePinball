using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;
    void Start()
    {
        PlayBGM();
    }

    void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
