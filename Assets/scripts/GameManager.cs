﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	private static GameManager _S;
	[Header("Dynamic")]
	[SerializeField]
	private bool movementLock=false;
	public static GameManager S {
		get {
			if (_S == null) {
				Debug.LogError ("Attempt to access GameManager singleton before initialization");
			}
			return _S;
		}
		set { 
			if (_S != null) {
				Debug.LogError ("Redundant attempt to create already initialized singleton. ");
			} else {
				_S = value;				
			}
		}
	}

	void Awake () {
		_S = this;
	}

	public static bool MOVEMENT_LOCK {
		get { return S.movementLock;}
		set {S.movementLock = value;}
	}
}
