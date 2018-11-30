using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public static GameManager Instance { get; private set; }
	BoardManager board;

	private void Awake()
	{
		if (Instance == null) {
			Instance = this;
		} else if(Instance != this) {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
		board = GetComponent<BoardManager>();
		InitGame();
	}

	void InitGame()
	{
		board.SetupScene();
	}
}
