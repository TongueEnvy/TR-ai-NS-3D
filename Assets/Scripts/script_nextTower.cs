using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_nextTower : MonoBehaviour {

    public List<GameObject> outerShards;
    public List<GameObject> innerShards;

    public GameObject pane;

    public float maxforwardSpeed;
    public float spreadSpeed;
    public float transitionTimer;
    float transitionCounter;

    bool hasShattered;

    // Use this for initialization
    void Start () {

        hasShattered = false;
        transitionCounter = transitionTimer;

	}
	
	// Update is called once per frame
	void Update () {
		
        if(hasShattered == true)
        {

            transitionCounter -= Time.deltaTime;

        }

        if(transitionCounter <= 0)
        {

            var toHumanity = Random.Range(0, 100);
            if (toHumanity >= 75)
            {

                SceneManager.LoadScene(0);

            }
            else
            {

                SceneManager.LoadScene(1);

            }

        }

	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player" && hasShattered == false)
        {
            Camera.main.transform.parent = gameObject.transform;

            GameObject.Find("scoreKeeper").GetComponent<sript_trackScore>().score += (5 + (3 * GameObject.Find("scoreKeeper").GetComponent<sript_trackScore>().humanity));

            hasShattered = true;

            other.gameObject.SetActive(false);

            pane.SetActive(false);

            foreach (GameObject item in outerShards)
            {
                item.SetActive(true);

                var willShatter = Random.Range(0f, 1f);
                if (willShatter >= .5f)
                {

                    item.GetComponent<script_rotate>().rotSpeed = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
                    item.GetComponent<script_translate>().moveSpeed = new Vector3(Random.Range(-spreadSpeed, spreadSpeed), Random.Range(-spreadSpeed, spreadSpeed), Random.Range(0, maxforwardSpeed));

                }

            }

            foreach (GameObject item in innerShards)
            {

                item.SetActive(true);

                item.GetComponent<script_rotate>().rotSpeed = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
                item.GetComponent<script_translate>().moveSpeed = new Vector3(Random.Range(-spreadSpeed, spreadSpeed), Random.Range(-spreadSpeed, spreadSpeed), Random.Range(0, maxforwardSpeed));

            }
        }

    }
}
