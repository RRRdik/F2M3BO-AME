using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScript : MonoBehaviour
{
    Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey("space"))
        {
            animator.SetBool("isJumping", true);
        }
        
        if (!Input.GetKey("space"))
        {
            animator.SetBool("isJumping", false);
        }
        
        if (Input.GetKey("w"))
        {
            animator.SetBool("isWalking", true);
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("isWalking", false);
        }
        
        if (Input.GetKey("a"))
        {
            animator.SetBool("isWalkingleft", true);
        }

        if (!Input.GetKey("a"))
        {
            animator.SetBool("isWalkingleft", false);
        }
        
        if (Input.GetKey("d"))
        {
            animator.SetBool("isWalkingright", true);
        }

        if (!Input.GetKey("d"))
        {
            animator.SetBool("isWalkingright", false);
        }
        
        if (Input.GetKey("s"))
        {
            animator.SetBool("isWalkingback", true);
        }

        if (!Input.GetKey("s"))
        {
            animator.SetBool("isWalkingback", false);
        }
    }

}
