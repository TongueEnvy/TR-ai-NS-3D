using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_japeThrowAnim : MonoBehaviour {

    public float throwTimer;
    public float throwCounter;

    public Animator anim;
    
    public AnimationClip throwing;

	// Use this for initialization
	void Start () {
        


	}
	
	// Update is called once per frame
	void Update () {

        throwCounter -= Time.deltaTime;

        if(throwCounter <= 0)
        {

            anim.Play(throwing.name);
            throwCounter = throwTimer;

        }

	}
}
