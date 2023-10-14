using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayAudio : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource bgMusicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip gametrack;
    public AudioClip gunshot;
    public AudioClip menuHover;
    public AudioClip hit;
    // Start is called before the first frame update
    void Start()
    {
        bgMusicSource.clip = gametrack;
        bgMusicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
