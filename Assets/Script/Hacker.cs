using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        ShowMainMenu("Hello There");
    }

    void ShowMainMenu(string greetings) 
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greetings);
        Terminal.WriteLine("Is your time to hack into their system Choose the person to hack:");
        Terminal.WriteLine("1. Secretary");
        Terminal.WriteLine("2. Manager");
        Terminal.WriteLine("3. CEO");
    }
    
    void OnUserInput(string input)
    {
        print(input);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
