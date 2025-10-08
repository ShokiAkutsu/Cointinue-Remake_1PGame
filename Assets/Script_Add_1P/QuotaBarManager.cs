using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuotaBarManager : MonoBehaviour
{
    [SerializeField] Text _costText;
    [SerializeField] float _speed = 0.5f;
    Rigidbody2D _rb;
    int _cost;

    void Start()
    {
        // ���̃o�[�̕K�v�R�X�g�́A�������ꂽ�Ƃ��Ɏ擾����
        _cost = 0;

        _rb = GetComponent<Rigidbody2D>();
		_rb.velocity = Vector2.down * _speed;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
        {
            // �R�C�������肽�Ƃ�
            if (_cost == 0)
            {
                // ����������R�X�g����������
            }
            else
            {
				// �R�C��������Ȃ��Ƃ�(�R���e�j���[�V�X�e�����Ăяo��)
			}

			// �Q�[�����s�o����Ȃ�A���̃o�[������
			Destroy(this.gameObject);
        } 
	}
}
