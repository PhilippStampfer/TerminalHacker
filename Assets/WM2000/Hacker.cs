using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game state
    int level;
    string greeting = "Hello";
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
    }
    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting + "\n"
            + "What would you like to hack? " + "\n" + "Press 1 for the local library" + "\n" + "Press 2 for the NASA");
        Terminal.WriteLine("Enter your selection");
    }
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    private void RunMainMenu(string input)
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
        else if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "Hunter X Hunter")
        {
            level = 3;
            Terminal.WriteLine("Welcome Ging!");

        }
        else
        {
            Terminal.WriteLine("Please enter a valid operation");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have choosen level " + level);
        Terminal.WriteLine("Please enter your password:  ");
    }

    // Update is called once per frame
    void Update()
    {



    }
}
