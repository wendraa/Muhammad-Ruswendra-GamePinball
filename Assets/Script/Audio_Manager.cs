using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
    void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }
    // Update is called once per frame
    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
