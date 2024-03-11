using System.Collections;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;

    public float maxTimeHold;
    public float maxForce;
    private Animator animator;

    private bool isHold = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        ReadInput(bola);
    }

    private void ReadInput(Collider collider)
    {
        if(Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
            isHold = true;
            animator.SetBool("Launch", true);
        }
        else
        {
            isHold = false; 
            animator.SetBool("Launch", false); 
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
    }
}
