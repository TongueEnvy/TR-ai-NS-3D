using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_throwJack : MonoBehaviour {

    public GameObject jack;

    public Vector2 throwVelocity;

    private void OnEnable()
    {

        var newJack = Instantiate<GameObject>(jack);

        newJack.transform.position = transform.position;

        newJack.GetComponent<Rigidbody>().velocity = new Vector3(throwVelocity.x, throwVelocity.y, 0);



    }
}
