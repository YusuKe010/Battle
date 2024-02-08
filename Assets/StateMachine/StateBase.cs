using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menber.Kawaguthi
{
	public class StateBase<T> where T : StateMachineBase<T>
	{
		protected T machine;

		public StateBase(T _machine)
		{
			machine = _machine;
		}

		/// <summary>
		/// このステートに変更する時の処理
		/// </summary>
		public virtual void OnEnterState() { }
		/// <summary>
		/// アップデートでする処理
		/// </summary>
		public virtual void OnUpdate() { }
		/// <summary>
		/// 別のステートに変更するときの処理
		/// </summary>
		public virtual void OnExitStte() { }
	}
}