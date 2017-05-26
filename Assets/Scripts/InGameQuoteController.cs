using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameQuoteController : MonoBehaviour {

	public Text QuoteText;
    public string[] QuoteInGame;
    public GameObject QuotePanel;
    private Animator anim;



    void Start () {
        anim = QuotePanel.GetComponent<Animator>();
		InvokeRepeating ("changeText",6.0f,9.0f);
        InvokeRepeating("changeTextEnd", 8.0f, 9.0f);
    }
	
	
	void Update () {
		
	}

	void changeText()
	{
        string textUpdate = QuoteInGame[Random.Range(0, QuoteInGame.Length)];
		QuoteText.text = textUpdate;
        anim.Play("QuoteInGameAnimation");
	}
    void changeTextEnd()
    {
        anim.Play("QuoteInGameAnimationEnd");
    }
}
