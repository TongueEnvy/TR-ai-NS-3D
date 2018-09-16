using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_humanityShard : MonoBehaviour {

    public GameObject humanitySlot;
    public GameObject humanity;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {

            humanity.GetComponent<script_humanityCompletion>().collectedShards += 1;
            humanitySlot.SetActive(true);
            Destroy(gameObject);

        }

    }
}
