using System;
using UnityEngine;
using Menber.Kawaguthi;

namespace Menber.Kawaguthi
{
	public class StateMachineBase<T> : MonoBehaviour where T : StateMachineBase<T>
	{
		private StateBase<T> _currentState;
		private StateBase<T> _nextState;

		public bool ChangeState(StateBase<T> nextState)
		{
			bool bRet = _nextState == null;
			_nextState = nextState;
			return bRet;
		}

		private void Update()
		{
			if (_nextState != null)
			{
				if (_currentState != null)
				{
					_currentState.OnExitStte();
				}

				_currentState = _nextState;
				_nextState.OnEnterState();
				_nextState = null;
			}

			if (_currentState != null)
			{
				_currentState.OnUpdate();
			}
		}
	}
}