using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menber.Kawaguthi
{
	public class Enemy : StateMachineBase<Enemy>, IAddDamage
	{
		private void Start()
		{
			Initialization();
		}

		void Initialization()
		{
			ChangeState(new Enemy.Normal(this));
		}
		


		public void AddDamage(float damage)
		{
			
		}

		public void Deth()
		{
			
		}
		
		//ノーマルステート
		public class Normal : StateBase<Enemy>
		{
			public Normal(Enemy machine) : base(machine) { }

			public override void OnEnterState()
			{
				
			}

			public override void OnUpdate()
			{
				
			}
		}
		
	}
	
}

