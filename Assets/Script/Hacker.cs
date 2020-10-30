﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game State
    int level;
    enum GameState { MainMenu, Password, Win };
    GameState currentState;
    // Start is called before the first frame update

    void Start()
    {
        ShowMainMenu("Hello There");
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "hackerman")
        {
            print("You won!!!!");
            currentState = GameState.Win;
        }
        else
        {
            print("You have taken a wrong path");
        }
    }

    void ShowMainMenu(string greetings)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greetings);
        Terminal.WriteLine("Is your time to hack into their system Choose the person to hack:");
        Terminal.WriteLine("1. Secretary");
        Terminal.WriteLine("2. Manager");
        Terminal.WriteLine("3. CEO");
        currentState = GameState.MainMenu;
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu("Why coming to the menu from the menu");
        }
        else if (currentState == GameState.MainMenu)
        {
            RunMainMenu(input);

        }
    }

    void StartGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You choose level " + level);
        currentState = GameState.Password;
    }
    // Update is called once per frame
    void Update()
    {

    }

}
