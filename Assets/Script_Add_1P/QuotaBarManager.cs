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
        // このバーの必要コストは、生成されたときに取得する
        _cost = 0;

        _rb = GetComponent<Rigidbody2D>();
		_rb.velocity = Vector2.down * _speed;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
        {
            // コインが足りたとき
            if (_cost == 0)
            {
                // 所持金からコスト分差し引く
            }
            else
            {
				// コインが足りないとき(コンテニューシステムを呼び出す)
			}

			// ゲーム続行出来るなら、このバーを消す
			Destroy(this.gameObject);
        } 
	}
}
