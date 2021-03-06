﻿using UnityEngine;
using FSM;

public class FSMIdleState : FSMBaseState {

	public FSMIdleState(LCBaseController controller) : base (controller)
	{

	}

	public override void StartState() {
		m_Controller.SetAnimation(EAnimation.Idle);
		m_Controller.CallBackEvent("OnIdle");
	}

	public override void UpdateState() {
		
	}

	public override void ExitState()
	{
		
	}

}
