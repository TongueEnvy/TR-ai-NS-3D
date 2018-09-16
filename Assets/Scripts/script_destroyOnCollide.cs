using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_destroyOnCollide : MonoBehaviour {

    public int bounces;

    private void OnCollisionEnter(Collision collision)
    {

        if (bounces > 0){

            bounces -= 1;

        }
        else
        {

            Destroy(gameObject);

        }
        

    }

}
