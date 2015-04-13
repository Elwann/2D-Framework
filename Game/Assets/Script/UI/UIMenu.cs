using UnityEngine;
using System.Collections;

[AddComponentMenu("2D Framework/UI/Menu")]
public class UIMenu : MonoBehaviour {
	public GameObject[] pages;
	private GameObject current;

	// Use this for initialization
	void Start () {
		if(StateManager.current == State.Start){
			Time.timeScale = 0f;
		} else if (StateManager.current == State.InGame){
			Time.timeScale = 1f;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void StartGame(){
		StateManager.StartGame();
	}

	public void ShowPage(int n){
		if(current != null){
			iTween.MoveTo(current, new Vector3(-Screen.width/2f, current.transform.position.y, 0f), 1f);
		}
		pages[n].transform.position = new Vector3(Screen.width/2f*3f, pages[n].transform.position.y, 0f);
		iTween.MoveTo(pages[n], new Vector3(Screen.width/2f, current.transform.position.y, 0f), 1f);
		current = pages[n];
	}

	public void HideCurrentPage(){
		if(current != null){
			iTween.MoveTo(current, new Vector3(-Screen.width/2f, current.transform.position.y, 0f), 1f);
			current = null;
		}
	}
}
