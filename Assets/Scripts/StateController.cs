using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateController : MonoBehaviour {

    public bool isMute = false;
    public Button muteButton;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Mute()
    {
        GameObject sound = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        if(sound.GetComponent<AudioListener>().isActiveAndEnabled == true)
        {
            sound.GetComponent<AudioListener>().enabled = false;
            muteButton.gameObject.GetComponent<Image>().color = Color.grey;
            isMute = true;
        }
        else
        {
            sound.GetComponent<AudioListener>().enabled = true;
            muteButton.gameObject.GetComponent<Image>().color = Color.white;
            isMute = true;
        }
    }   
}
