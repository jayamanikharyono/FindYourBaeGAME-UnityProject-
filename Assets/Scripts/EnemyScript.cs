using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public Canvas gameOverCanvas;
    public GameObject player;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameOverCanvas.gameObject.SetActive(true);
            player.GetComponent<PlayerController>().enabled = false;
        }
    }
}
