using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Animator is attached to the "Sprite" child
        animator = GetComponentInChildren<Animator>();

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the player is moving, set animator speed to 1
        //animator.SetFloat("speed", rb.velocity.x > 0 || rb.velocity.y > 0 ? 1 : 0);
        animator.SetFloat("xDir", Mathf.Abs(rb.velocity.x));
    }
}
