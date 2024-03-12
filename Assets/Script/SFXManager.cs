using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sfxSource;
    void Start()
    {
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSource, spawnPosition, Quaternion.identity);
    }
}
