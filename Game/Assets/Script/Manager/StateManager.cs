using UnityEngine;
using System.Collections;

public static class StateManager {
	public static State current = State.Start;

	public static void StartGame(){
		Time.timeScale = 1f;
	}

	public static void PauseGame(){
		Time.timeScale = 0f;
	}

	public static void UnPauseGame(){
		Time.timeScale = 1f;
	}

	public static bool IsGamePaused(){
		return (Time.timeScale == 0f) ? true : false;
	}
}

public enum State{ Start, InGame }