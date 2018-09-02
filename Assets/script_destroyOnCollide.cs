using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_destroyOnCollide : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {

        Destroy(gameObject);

    }

}
