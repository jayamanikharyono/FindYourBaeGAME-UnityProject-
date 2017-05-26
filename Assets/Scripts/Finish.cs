using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    public Canvas reward,giveUpCanvas,buttonCanvas;
    public GameObject rewardPanel;
    private Animator anim;
    public int timeRemaining;
    public int nextLevel;

    void Start () {
        buttonCanvas.gameObject.SetActive(false);
        anim = rewardPanel.GetComponent<Animator>();
        //anim.enabled = false;
        giveUpCanvas.gameObject.SetActive(false);
        reward.gameObject.SetActive(false);
        InvokeRepeating("enableGiveUpButton",timeRemaining,timeRemaining);
    }
	
	void Update () {

	}

    void OnTriggerEnter()
    {
        Debug.Log("Finish");
        showReward();
    }

    public void showReward()
    {
        reward.gameObject.SetActive(true);
        //anim.Play("PauseMenuSlideIn");
    }

    public void GiveUpButton()
    {
        giveUpCanvas.gameObject.SetActive(true);
    }

    public void enableGiveUpButton()
    {
        buttonCanvas.gameObject.SetActive(true);
    }
    public void backToMenu()
    {
        Application.LoadLevel("MainMenu");
    }
    public void nextScene()
    {
        Debug.Log(nextLevel);
        Application.LoadLevel(nextLevel);
    }
}
