using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //startgame
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("BtnStartPressed");
    }

    //End Game
    public void EndGame()
    {
        Application.Quit();
        Debug.Log("BtnEndPressed");
    }
}
