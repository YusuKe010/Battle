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

		public virtual void OnEnterState() { }
		public virtual void OnUpdate() { }
		public virtual void OnFixedUpdate(){}
		public virtual void OnExitStte() { }
	}
}