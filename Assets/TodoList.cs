using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TodoList : MonoBehaviour
{
    private void OnGUI()
    {
        GUI.Label(new Rect(60, 30, 80, 30), "TO DO LIST:", EditorStyles.boldLabel);
        if (GameManager.CurrentDay == 0)
        {
            GUI.Label(new Rect(60, 60, 80, 20), "Shave beard", EditorStyles.foldout);
            GUI.Label(new Rect(60, 80, 80, 20), "Go to the kitchen and eat healthy meal", EditorStyles.centeredGreyMiniLabel);
        }
        else if (GameManager.CurrentDay == 1)
        {
            GUI.Label(new Rect(0, 0, 80, 20), "Go to the computer in the bedroom and order sports equipment", EditorStyles.foldout);
            GUI.Label(new Rect(60, 80, 80, 20), "Go to the kitchen and eat healthy meal", EditorStyles.centeredGreyMiniLabel);
        }
        else if (GameManager.CurrentDay == 2)
        {
            GUI.Label(new Rect(0, 0, 80, 20), "Pick up dirty clothing from the bedroom", EditorStyles.foldout);
            GUI.Label(new Rect(60, 80, 80, 20), "Go to the kitchen and eat healthy meal", EditorStyles.centeredGreyMiniLabel);
        }
        else if (GameManager.CurrentDay == 3)
        {
            GUI.Label(new Rect(0, 0, 80, 20), "Clean up the house and throw out all of the trash", EditorStyles.foldout);
            GUI.Label(new Rect(60, 80, 80, 20), "Go to the kitchen and eat healthy meal", EditorStyles.centeredGreyMiniLabel);
        }
        else if (GameManager.CurrentDay == 4)
        {
            GUI.Label(new Rect(0, 0, 80, 20), "Exercise with new gym set", EditorStyles.foldout);
            GUI.Label(new Rect(60, 80, 80, 20), "Go to the kitchen and eat healthy meal", EditorStyles.centeredGreyMiniLabel);
        }
        else if (GameManager.CurrentDay == 5)
        {
            GUI.Label(new Rect(0, 0, 80, 20), "Exercise with new gym set twice", EditorStyles.foldout);
            GUI.Label(new Rect(60, 80, 80, 20), "Go to the kitchen and eat healthy meal", EditorStyles.centeredGreyMiniLabel);
        }
        else if (GameManager.CurrentDay == 6)
        {
            GUI.Label(new Rect(0, 0, 80, 20), "Go to the computer in the bedroom and Order new clothes", EditorStyles.foldout);
            GUI.Label(new Rect(60, 80, 80, 20), "Go to the kitchen and eat healthy meal", EditorStyles.centeredGreyMiniLabel);
        }
        else if (GameManager.CurrentDay == 7)
        {
            GUI.Label(new Rect(0, 0, 80, 20), "Try out new clothes", EditorStyles.foldout);
            GUI.Label(new Rect(60, 80, 80, 20), "Go to the kitchen and eat healthy meal", EditorStyles.centeredGreyMiniLabel);
        }

    }
}
