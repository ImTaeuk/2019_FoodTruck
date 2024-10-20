using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip clip;
}*/
public class SoundManager2 : MonoBehaviour
{
    /*[Header("사운드 등록")]
    [SerializeField]
    public Sound[] bgmSounds;
    [Header("브금 플레이어")]
    [SerializeField]*/
    /*public static SoundManager2 instance;
    public AudioSource bgmPlayer;
    public AudioSource ClickSound;
    
    public void PlayClickSound()
    {
        ClickSound.Play();
    }

    private void Awake()
    {
        instance = this;
    }*/
    public static SoundManager2 instance;
    public AudioSource ClickSound;
    public AudioSource ThemeSound;
    public void PlayClickSound()
    {
        ClickSound.Play();
    }
    private void Awake()
    {
        instance = this;
        ThemeSound.volume = SoundManager.instance.volumeBgm;
        ClickSound.volume = SoundManager.instance.volumeClick;
    }
    private void Update()
    {
    }
}


