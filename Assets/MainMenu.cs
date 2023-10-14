using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    GamePlayAudio m_AudioManager;
    public void Awake()
    {
        m_AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<GamePlayAudio>();
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void HoverSound()
    {
        m_AudioManager.PlaySFX(m_AudioManager.menuHover);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
