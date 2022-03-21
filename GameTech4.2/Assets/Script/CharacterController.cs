using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            anim.SetBool("isWalking", true);
            transform.position += transform.forward * Time.deltaTime * 2;
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("isWaving", true);
        }
    }

    public void WavingOver(string message)
    {
        if (message.Equals("WaveAnimationEnded"))
        {
            anim.SetBool("isWaving", false);
        }
    }
}
