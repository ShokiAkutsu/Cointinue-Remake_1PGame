using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillNeedle : MonoBehaviour, ISkillEffect
{
	[SerializeField] GameObject _needle;
	[SerializeField] float _fallPos = 5f;

	public void Execute(PlayerID usePlayerID)
	{
		// ‘ŠŽè‘¤‚ÌPosition‚ðŽæ“¾
		Vector3 targetPos = PlayerIDManager.Instance.GetPlayerPosition(PlayerID.Player_1P);

		Instantiate(_needle, new Vector3(targetPos.x, _fallPos), Quaternion.identity);
	}
}
