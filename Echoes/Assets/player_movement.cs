using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

    Rigidbody rb;

    public GameObject model;
    public GameObject armature;

    Animator anim;

    public AnimationClip stand;
    public AnimationClip walk;
    public AnimationClip jump;

    bool lookingRight;
    bool isJumping;
    bool grounded;

    public float jumpForce;
    public float jumpAccel;
    public float jumpTimer;
    float jumpCounter;

    public float moveSpeed;


	// Use this for initialization
	void Start () {

        rb = gameObject.GetComponent<Rigidbody>();
        anim = armature.GetComponent<Animator>();
        isJumping = false;
        grounded = false;

	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetAxisRaw("Horizontal") > 0)
        {

            lookingRight = true;

        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {

            lookingRight = false;

        }

        if(rb.velocity.x == 0 && grounded == true)
        {

            anim.speed = 1;
            anim.Play(stand.name);

            if(lookingRight == true)
            {
                
                model.transform.eulerAngles = new Vector3(0, -45, 0);

            }
            else if (lookingRight == false)
            {

                model.transform.eulerAngles = new Vector3(0, 45, 0);

            }

        }
        else
        {

            if(grounded == false)
            {

                anim.speed = 1;
                anim.Play(jump.name);

            }
            else if (grounded == true)
            {

                anim.speed = Mathf.Abs(Input.GetAxisRaw("Horizontal"));
                anim.Play(walk.name);

            }

            if (lookingRight == true)
            {

                model.transform.eulerAngles = new Vector3(0, -90, 0);

            }
            else if (lookingRight == false)
            {

                model.transform.eulerAngles = new Vector3(0, 90, 0);

            }


        }

        rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y, 0);

        if (Input.GetButtonDown("Jump") && grounded == true)
        {

            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
            jumpCounter = jumpTimer;
            isJumping = true;

        }

        jumpCounter -= Time.deltaTime;

        if (jumpCounter <= 0)
        {

            jumpCounter = 0;
            isJumping = false;

        }

        if (Input.GetButtonUp("Jump"))
        {

            jumpCounter = 0;
            isJumping = false;

        }

        if(isJumping == true)
        {

            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y + jumpAccel, 0);

        }

    }

    void OnTriggerEnter(Collider other)
    {

        grounded = true;
        isJumping = false;

    }

    void OnTriggerExit(Collider other)
    {

        grounded = false;


    }

    private void OnTriggerStay(Collider other)
    {

        grounded = true;

    }
}
