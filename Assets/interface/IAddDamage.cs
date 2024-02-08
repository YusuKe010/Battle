using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAddDamage
{
	/// <summary>
	/// ダメージを与える場合負の値を入れる、回復の場合正の値を入れる
	/// </summary>
	/// <param name="damage"></param>
	void AddDamage(float damage);

	/// <summary>
	/// 死んだ時の処理
	/// </summary>
	void Deth();
}
