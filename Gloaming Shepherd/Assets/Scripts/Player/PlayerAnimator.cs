using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    private PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        // Animator is attached to the "Sprite" child
        animator = GetComponent<Animator>();

        pc = GetComponentInParent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the player is moving, set animator speed to 1
        SetSpeed();

        animator.SetFloat("xDir", Mathf.Abs(pc.MoveVector.x));
        animator.SetFloat("zDir", pc.MoveVector.z);
    }

    public void StartAttack()
    {
        animator.SetBool("attacking", true);
    }

    public void EndAttack()
    {
        pc.EndAttack();
        animator.SetBool("attacking", false);
    }

    private void SetSpeed()
    {
        if (pc.MoveVector.x != 0)
        {
            animator.SetFloat("speed", Mathf.Abs(pc.MoveVector.x));
        }
        else if (pc.MoveVector.z != 0)
        {
            animator.SetFloat("speed", Mathf.Abs(pc.MoveVector.z));
        }
        else
        {
            animator.SetFloat("speed", 0f);
        }
    }
}
