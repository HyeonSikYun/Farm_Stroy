﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Scene : UI_Base
{
	public override void Init()
	{
		UI_Manager.Instance.SetCanvas(gameObject, false);
	}
}
