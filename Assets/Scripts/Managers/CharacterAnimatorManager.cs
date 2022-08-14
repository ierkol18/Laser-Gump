using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimatorManager : Singleton<CharacterAnimatorManager>
{
    private Animator animator;

    private void Start(){
     animator = GetComponent<Animator>();

    }
    public void run(){
        animator.SetBool("running", true);
    }
    public void stopRunning()
    {
        animator.SetBool("running", false);
    }
}
