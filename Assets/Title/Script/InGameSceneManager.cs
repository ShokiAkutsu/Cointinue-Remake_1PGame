using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameSceneManager : MonoBehaviour
{
	int _inGameIndex = 1;

	void Update()
    {
		if (Input.GetKeyDown(KeyCode.Return))
		{
			SceneManager.LoadScene(_inGameIndex);
		}
    }
}
