using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sounds
{
    public string soundName;
    public AudioClip clip;
    public AudioSource source;
}
public class EffectManager : MonoBehaviour
{
    [SerializeField]
    int size;
    [Header("사운드 등록")]
    [SerializeField] Sounds[] effectSounds;

    void Start()
    {
        for (int i = 0; i < size; i++)
        {
            this.effectSounds[i].source = this.gameObject.AddComponent<AudioSource>();
        }

    }
    
    void Update()
    {
        
    }
}
