using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_humanityCompletion : MonoBehaviour {

    public GameObject score;

    public int collectedShards;

    private void Start()
    {

        score = GameObject.Find("scoreKeeper");

    }

    private void Update()
    {
        
        if(collectedShards == 5)
        {

            score.GetComponent<sript_trackScore>().humanity += 1;

            SceneManager.LoadScene(1);

        }

    }
}
