using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource bgMusicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip gametrack;
    public AudioClip menuHover;
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
    public void HoverSound()
    {
        SFXSource.PlayOneShot(menuHover);
    }
}
