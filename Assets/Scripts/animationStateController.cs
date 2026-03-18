using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash = Animator.StringToHash("isWalking");
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool walking = Input.GetKey("w");
        bool isWalking = animator.GetBool(isWalkingHash);

        if (walking != isWalking)
        {
            animator.SetBool(isWalkingHash, walking);
        }
    }
}
