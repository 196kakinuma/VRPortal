﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IkLibrary;

public class GameMaster : SingletonMonoBehaviour<GameMaster> {

    [SerializeField]
    Camera mainCamera;
    [SerializeField]
    Camera subCamera;

    bool anotherWorld = false;
    public bool IsAnotherWorld()
    {
        return anotherWorld;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// 使用するかめらを変更する
    /// </summary>
    public void ChangeWorld()
    {
        subCamera.depth *= -1;
        anotherWorld = !anotherWorld;
    }

}
