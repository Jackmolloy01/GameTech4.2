using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    private Animator anim;
    private bool action, ragdoll;
    public AudioClip clip;
    private AudioSource audioSource;
    private ParticleSystem ps;

    void Start()
    {
        anim = GetComponent<Animator>();
        action = false;
        ragdoll = false;
        audioSource = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        if(action == false && ragdoll == false)
        {
            transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));
        }
        anim.SetFloat("x", horizontal);
        anim.SetFloat("y", vertical);

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("isWaving", true);
            action = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("isKicking", true);
            action = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            anim.SetBool("isBlocking", true);
            action = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().enabled = false;
            ragdoll = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void Step()
    {
        audioSource.PlayOneShot(clip);
        ps.Play();
    }
    private void Particle()
    {
        audioSource.PlayOneShot(clip);
    }

    public void WavingOver(string message)
    {
        if (message.Equals("WaveAnimationEnded"))
        {
            anim.SetBool("isWaving", false);
            action = false;
        }
    }
    public void KickOver(string message)
    {
        if (message.Equals("KickEnded"))
        {
            anim.SetBool("isKicking", false);
            action = false;
        }
        if (message.Equals("BlockAnimationEnded"))
        {
            anim.SetBool("isBlocking", false);
            action = false;
        }
    }
    public void BlockOver(string message)
    {
        if (message.Equals("BlockEnded"))
        {
            anim.SetBool("isBlocking", false);
            action = false;
        }
    }
}
