using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {
	// 床と壁のプレハブ
	[SerializeField]
	private GameObject[] Floors;
	[SerializeField]
	private GameObject[] Walls;
	
	private int row = 8;	// 行
	private int column = 8;	// 列
	private Transform boardHolder;	// ボードの状態を保持するオブジェクト

	void BoardSetup()
	{
		boardHolder = new GameObject("Board").transform;
		for (int x = -1; x < column + 1; x++) {
			for (int y = -1; y < row + 1; y++) {
				var prefab = Floors[Random.Range(0, Floors.Length)];
				if (x == -1 || y == -1 || x == column || y == row) {
					prefab = Walls[Random.Range(0, Walls.Length)];
				}
				var instance = Instantiate(prefab, new Vector3(x, y, 0), Quaternion.identity, boardHolder);
			}
		}
	}
	public void SetupScene()
	{
		BoardSetup();
	}
}
