using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sript_trackScore : MonoBehaviour {

    public float score;
    public int humanity;

    public Text scoreText;
    public Text humanityText;

    private void Awake()
    {

        DontDestroyOnLoad(gameObject);

    }

    // Use this for initialization
    void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {

        scoreText.text = "Score:" + score.ToString();
        humanityText.text = "Humanity:" + humanity.ToString(); 

    }
}
