using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GYMScript : MonoBehaviour {
	public KMBombModule module;
	public KMBombInfo bomb;
	public KMAudio sound;
	
	private int _moduleID;
	private static int _moduleIDCounter = 1;
	private bool _isModuleSolved;
	void Start () {
		
	}

}
