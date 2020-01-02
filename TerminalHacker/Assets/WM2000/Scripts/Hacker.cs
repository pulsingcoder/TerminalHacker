using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //gane state
    int level;
    // setuping enumerator
    enum Screen { MainMenu, Password, Win};
    // a variable to store current screen
    Screen currentScreen = Screen.MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        ShowStartMenu();
    }
    void ShowStartMenu()
    {
        Terminal.ClearScreen();
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine("What would you like to hack into");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("1.> A local Library");
        Terminal.WriteLine("2.> Indian Army Server");
        Terminal.WriteLine("3.> ISRO Server");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Enter your selection");

    }
    void OnUserInput(string input)
    {
        if (input== "menu" || input == "MENU" || input == "Menu")
        {
            ShowStartMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
       
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
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else
        {

            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have choose level " + level);
        Terminal.WriteLine("Please enter password");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
