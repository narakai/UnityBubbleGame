﻿using UnityEngine;
using System.Collections;

public class SpecialCheckCollider : MonoBehaviour {

	SpecialBubbleUnit bubble;

	void OnEnable()
	{
		bubble = GetComponentInParent<SpecialBubbleUnit> ();
	}
   
	void OnTriggerEnter2D(Collider2D other) {

	     if (other.CompareTag ("Bubble")) {
			bubble.DealEffectCleanBubble(other.GetComponent<BubbleUnit>());
		}
	}

}
