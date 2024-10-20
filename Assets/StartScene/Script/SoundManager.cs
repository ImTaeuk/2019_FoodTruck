using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource ClickSound;
    public AudioSource ThemeSound;
    public GameObject SettingMenu;
    public float volumeClick;
    public float volumeBgm;
    public void StartClickSound()
    {
        ClickSound.Play();
    }
    private void Awake()
    {
        //DontDestroyOnLoad(this);
        instance = this;
        ThemeSound.volume = ClickSound.volume = 0.5f;
        ThemeSound.Play();
        SettingMenu.SetActive(false);
    }
    private void Update()
    {
    }
}
