using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SkillBeam : MonoBehaviour, ISkillEffect
{
	[SerializeField] GameObject _blueShot; // ��
	[SerializeField] GameObject _warning; // �x���}�[�N
	[SerializeField] float _warningSec = 1f; // �x���}�[�N���o������
	[SerializeField] float _speed = 3f;
	bool _isPlayer1; // �g�pPlayer��1P���ǂ���

	SkillBeam _skillBeam;

	public void Execute(PlayerID usePlayerID)
	{
		_isPlayer1 = usePlayerID == PlayerID.Player_1P;

		ShotSkillStart(PlayerID.Player_1P);
	}

	void ShotSkillStart(PlayerID targetID)
	{
		// �ł��o���ꏊ���`
		float _shotX = 15f;

		Vector3 targetPos = PlayerIDManager.Instance.GetPlayerPosition(targetID); // ����̏ꏊ�����

		bool isPlusX = targetPos.x > 0;

		// �ł��o��
		// �����𒲐�
		Vector3 shotPosition = new Vector3(_shotX * (isPlusX  ? -1 : 1), targetPos.y);
		GameObject shot = Instantiate(_blueShot, shotPosition, Quaternion.identity);

		// �i�s�����Ɍ������ăr�[������]������
		float angle = isPlusX ? -90 : 90;
		shot.transform.rotation = Quaternion.Euler(0, 0, angle);

		// ������
		Vector3 vec = isPlusX ? Vector3.right : Vector3.left;
		shot.GetComponent<Rigidbody2D>().velocity = vec * _speed;
	}
}
