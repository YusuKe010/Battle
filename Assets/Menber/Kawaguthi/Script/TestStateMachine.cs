using System;
using UnityEngine;
using UnityEngine.PlayerLoop;


namespace Menber.Kawaguthi
{
	public class TestStateMachine : StateMachineBase<TestStateMachine>
	{
		void Start()
		{
			ChangeState(new TestStateMachine.Neutral(this));
		}
		

		private class Neutral : StateBase<TestStateMachine>
		{
			public Neutral(TestStateMachine machine) : base(machine)
			{
				
			}

			public override void OnEnterState()
			{
				Debug.Log("Neutral");
			}

			public override void OnUpdate()
			{
				if (Input.GetKey(KeyCode.UpArrow))
				{
					machine.ChangeState(new Up(machine));
				}
				else if (Input.GetKey(KeyCode.LeftArrow))
				{
					machine.ChangeState(new Left(machine));
				}
			}
		}
		
		private class Up : StateBase<TestStateMachine>
		{
			public Up(TestStateMachine machine) : base(machine)
			{
				
			}
			
			public override void OnEnterState()
			{
				Debug.Log("Up");
			}
			public override void OnUpdate()
			{
				if (Input.GetKey(KeyCode.Escape))
				{
					machine.ChangeState(new Neutral(machine));
				}
				else if (Input.GetKey(KeyCode.LeftArrow))
				{
					machine.ChangeState(new Left(machine));
				}
			}
		}
		
		private class Left : StateBase<TestStateMachine>
		{
			public Left(TestStateMachine machine) : base(machine)
			{
				
			}
			public override void OnEnterState()
			{
				Debug.Log("Left");
			}
			public override void OnUpdate()
			{
				if (Input.GetKey(KeyCode.UpArrow))
				{
					machine.ChangeState(new Up(machine));
				}
				else if (Input.GetKey(KeyCode.Escape))
				{
					machine.ChangeState(new Neutral(machine));
				}
			}
		}
	}
	
}