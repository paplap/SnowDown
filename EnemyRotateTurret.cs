﻿using UnityEngine;
using System.Collections;

public class EnemyRotateTurret : BaseRotateTurret {
	public Transform player;
	
	
	// Update is called once per frame
	override protected void Update() {
		
		if (player != null) {
			targetPos = player.position;
			base.Update ();
		}
	}
}
