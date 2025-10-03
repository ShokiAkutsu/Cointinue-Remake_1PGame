using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTraking : MonoBehaviour, ISkillEffect
{
	[SerializeField] GameObject _traking;
	[SerializeField] Vector3 _position = new Vector3(0, -7);

	public void Execute(PlayerID usePlayerID)
	{
		GameObject traking = Instantiate(_traking, _position, Quaternion.identity);

		traking.GetComponent<Traking>().FindTarget(PlayerID.Player_1P);
	}
}
