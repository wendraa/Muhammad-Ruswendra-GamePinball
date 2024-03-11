using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXOn : MonoBehaviour
{
    public GameObject sfxONSource;
    void Start()
    {
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxONSource, spawnPosition, Quaternion.identity);
    }
}
