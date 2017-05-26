using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public GameObject AboutUsCanvas;
    public GameObject MainMenuCanvas;
    public GameObject QuoteGameCanvas;

	// Use this for initialization
	void Start () {
        MainMenuCanvas.gameObject.SetActive(true);
        AboutUsCanvas.gameObject.SetActive(false);
        QuoteGameCanvas.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayButton()
    {
        QuoteGameCanvas.gameObject.SetActive(true);
        MainMenuCanvas.gameObject.SetActive(false);
    }
    public void AboutUsButton()
    {
        AboutUsCanvas.gameObject.SetActive(true);
        MainMenuCanvas.gameObject.SetActive(false);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void backButton()
    {
        AboutUsCanvas.gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
    }
    public void loadlevel()
    {
        Application.LoadLevel("Level1");
    }
}
