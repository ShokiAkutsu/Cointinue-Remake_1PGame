using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSystemManager : MonoBehaviour
{
	SkillDeckManager _deckManager;
	bool _isPause = false;

	private void Start()
	{
		_deckManager = GameObject.FindObjectOfType<SkillDeckManager>();
	}

	private void OnEnable()
	{
		PauseManager.OnPause += Pause;
		PauseManager.OnResume += Resume;
	}

	private void OnDisable()
	{
		PauseManager.OnPause -= Pause;
		PauseManager.OnResume -= Resume;
	}

	void Update()
    {
		// スキルキー設定を構造体から取得
		InputSkillKey config = SkillKeyConfig.GetConfig(PlayerID.Player_1P);

		// 入力チェック
		if (Input.GetKeyDown(config.LeftSkill))
		{
			_deckManager.TryActivate(SkillPosition.Left);
		}
		else if (Input.GetKeyDown(config.CenterSkill))
		{
			_deckManager.TryActivate(SkillPosition.Center);
		}
		else if (Input.GetKeyDown(config.RightSkill))
		{
			_deckManager.TryActivate(SkillPosition.Right);
		}
	}

	private void Pause()
	{
		_isPause = true;
	}

	void Resume()
	{
		_isPause = false;
	}
}