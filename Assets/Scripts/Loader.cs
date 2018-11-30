using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {
	[SerializeField]
	private GameManager manager;

	private void Awake()
	{
		if (GameManager.Instance == null)
		{
			Instantiate(manager);
		}
	}
}
