using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_animations : MonoBehaviour {

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var rotMod = -1;
        if(GetComponent<player_stats>().lookingRight == false)
        {

            rotMod = 1;

        }

        var rotAngle = 90;
        if(GetComponent<player_stats>().grounded == true && Input.GetAxisRaw("Horizontal") == 0)
        {

            rotAngle = 45;

        }

        GetComponent<player_stats>().model.transform.eulerAngles = new Vector3(0, rotAngle * rotMod, 0);

        if (GetComponent<player_stats>().onWall == true)
        {

            GetComponent<player_stats>().anim.Play(GetComponent<player_stats>().wallCling.name);

        }
        else if(GetComponent<player_stats>().grounded == false)
        {

            GetComponent<player_stats>().anim.Play(GetComponent<player_stats>().jump.name);

        }
        else if(GetComponent<player_stats>().grounded == true)
        {


            if(Input.GetAxisRaw("Horizontal") != 0)
            {

                GetComponent<player_stats>().anim.Play(GetComponent<player_stats>().walk.name);

            }
            else if (Input.GetAxisRaw("Horizontal") == 0)
            {

                GetComponent<player_stats>().anim.Play(GetComponent<player_stats>().stand.name);

            }

        }

	}
}
