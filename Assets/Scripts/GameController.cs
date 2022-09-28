//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;

//public class GameController : MonoBehaviour
//{
//    public Enum GameState {MENU, GAME, GAMEOVER}
//    public static GameSate gameState;

//    [Header("Managers")]

//    public SnakeController SC;
//    public BlockManager BM;

//    [Header("CanvasGroup")]

//    public CanvasGroup MENU_CG;
//    public CanvasGroup GAME_CG;
//    public CanvasGroup GAMEOVER_CG;

//    [Header("ScoreManagement")]

//    public Text ScoreText;
//    public Text MenuScoreText;
//    public Text BestScoreText;
//    public static int SCORE;
//    public static int BESTSCORE;

//    bool speedAdded;

//    void Srart()
//    {
//        SetMenu();
//        SCORE = 0;

//        speedAdded = false;
//        BESTSCORE = PlayerPrefs.GetInt("BESTSCORE");
//    }
    
//    void Update()
//    {
//        ScoreText.text = SCORE + "";
//        MenuScoreText.text = SCORE + "";

//        if
//    }


//}
