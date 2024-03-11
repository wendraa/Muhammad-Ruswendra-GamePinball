using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxAudioSource;

    // Update is called once per frame
    public void PlayVFX(Vector3 spawnposition)
    {
        GameObject.Instantiate(vfxAudioSource, spawnposition, Quaternion.identity);
    }
}
