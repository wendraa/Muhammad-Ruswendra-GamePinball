using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSourec;

    private void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgmAudioSourec.Play();
    }
}
