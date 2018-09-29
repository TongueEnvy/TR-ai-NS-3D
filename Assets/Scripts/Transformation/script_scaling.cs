using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_scaling : MonoBehaviour {

    public float scaling;

    public GameObject parent;

    private void Start()
    {

        parent = transform.parent.gameObject;

    }

    // Update is called once per frame
    void Update () {

        transform.parent = null;
        transform.localScale =(transform.localScale * (1 + scaling));

	}
}
