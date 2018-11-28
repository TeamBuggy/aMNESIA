﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VesicleController : MonoBehaviour
{
	
	[SerializeField] private MainController main;

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			main.GameOver();
			Destroy(gameObject);
		}
	}
}
