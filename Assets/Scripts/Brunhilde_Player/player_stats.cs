using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_stats : MonoBehaviour {

    [Header("General Variables")]
    public Rigidbody rb;
    public bool lookingRight;
    public GameObject model;

    [Header("Animations")]
    public Animator anim;

    public AnimationClip stand;
    public AnimationClip walk;
    public AnimationClip jump;
    public AnimationClip wallCling;

    [Header("Horizontal Movement Variables")]
    public bool manualMove;
    public float horMoveSpeed;

    [Header("Jumping Variables")]
    public bool isJumping;
    public bool grounded;
    public bool onWall;
    public float jumpForce;
    public float jumpAccel;
    public float jumpTimer;
    public float jumpCounter;
    public float wallJumpTimer;
    public float wallJumpCounter;
    public float wallSlideSpeed;
    public Vector2 wallJumpForce;
    public int wallJumpMod;

    // Use this for initialization
    void Start () {

        rb = gameObject.GetComponent<Rigidbody>();
        isJumping = false;
        grounded = false;
        onWall = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
