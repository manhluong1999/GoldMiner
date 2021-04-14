﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class LevelPlay : MonoBehaviour {
    private void Start() {
        LoadLevel();
    }
    
    public  void LoadLevel() {
        int level_index = LevelsManager.Instance.GetCurrentLevel().index;
        Debug.Log("LevelPlay Level Index :"+ level_index);
         var level_prefab = Resources.Load("Levels/Level"+level_index) as GameObject;
         var level_content = Instantiate(level_prefab, transform.position, transform.rotation);

        InLevelManager.Instance.EnterLevel();
    }
}