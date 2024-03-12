using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Switch_Controller : MonoBehaviour
{

    private enum SwitchState
    {
        off,
        on,
        Blink
    }

    public Collider bola;
    public Material OFFMaterial;
    public Material ONMaterial;
    public float score;
    public SFXManager sFXManager;
    public SFXOn soundManager;
    public VisualFXManager vfxManager;

    public ScoreManager scoreManager;

    private SwitchState state;
    private Renderer rendere;


    private void Start()
    {
        rendere = GetComponent<Renderer>();
        Set(false);

        BlinkTimerStart(5);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other == bola)
        {
            toggle();
        }
    }

    private void Set(bool active)
    {

        if (active == true)
        {
            state = SwitchState.on;
            rendere.material = ONMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.off;
            rendere.material = OFFMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void toggle()
    {
        if (state == SwitchState.on)
        { 
            Set(false);
            soundManager.PlaySFX(transform.position);
            vfxManager.PlayVFX(transform.position);
        }
        else
        {
            Set(true);
            scoreManager.AddScore(score);
            sFXManager.PlaySFX(transform.position);
            vfxManager.PlayVFX(transform.position);
        }
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;
        for (int i = 0; i < times; i++)
        {
            rendere.material = ONMaterial;
            yield return new WaitForSeconds(0.5f);
            rendere.material = OFFMaterial;
            yield return new WaitForSeconds(0.5f);
        }
        state = SwitchState.off;
    }

    private IEnumerator BlinkTimerStart (float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
