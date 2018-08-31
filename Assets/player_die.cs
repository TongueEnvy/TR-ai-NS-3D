using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_die : MonoBehaviour {

    public GameObject gib;
    public GameObject mesh;
    public int minGibNumber;
    public int MaxGibNumber;
    public float gibVelMod;
    public float respawnTimer;
    float respawnCounter;
    bool hasDied = false;

    void Start()
    {

        respawnCounter = respawnTimer;

    }

    private void FixedUpdate()
    {

        if (hasDied == true)
        {

            respawnCounter -= Time.deltaTime;

            if (respawnCounter <= 0)
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {

        

        if (other.tag == "Hazard" && hasDied == false)
        {

            hasDied = true;

            mesh.SetActive(false);

            var gibNum = (int)Random.Range(minGibNumber, MaxGibNumber);
            for(var i = 0; i < gibNum; i += 1)
            {

                var newGib = Instantiate<GameObject>(gib);
                newGib.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity + new Vector3(Random.Range(-gibVelMod, gibVelMod),Random.Range(-gibVelMod,gibVelMod),0);
                newGib.transform.position = transform.position + new Vector3(Random.Range(-.5f,.5f), 1 + Random.Range(-.5f, .5f), Random.Range(-.5f, .5f));

            }

            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<player_movement>().enabled = false;
            
        }

    }
}
