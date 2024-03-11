using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{

    public Collider bola;
    public float multiplayer;
    public Color color;
    public bool randomColor = false;
    public Audio_Manager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;
    public float score;

    private Animator animator;
    private new Renderer renderer;
    

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        if (randomColor)
        {
            
            color = Random.ColorHSV();
        }
        GetComponent<Renderer>().material.color = color;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola )
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplayer;

            animator.SetTrigger("Hit");

            audioManager.PlaySFX(collision.transform.position);

            vfxManager.PlayVFX(collision.transform.position);
            
            scoreManager.AddScore(score);
        }
    }
}
