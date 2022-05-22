using SQLite;
using Stateless;
using UnityEngine;


public class UsageSandbox : MonoBehaviour
{

	void Start()
	{
		var machine = new StateMachine<State, Trigger>(State.Initial);
		machine.Configure(State.Initial)
			.Permit(Trigger.Start, State.Alive);

		var connection = new SQLiteAsyncConnection("file.db");
	}

	enum State
	{
		Initial,
		Alive,
	}

	enum Trigger
	{
		Start
	}
}
