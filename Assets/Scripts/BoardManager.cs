﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {
	public GameObject[] levels;

	private Transform boardHolder;

	public void SetupScene (int level)
	{
		//Instantiate Board and set boardHolder to its transform.
		boardHolder = new GameObject ("Board").transform;

		GameObject instance =
			Instantiate (levels[level], new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
		instance.transform.SetParent (boardHolder);
	}
}