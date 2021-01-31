using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TodoList : MonoBehaviour
{
    private void OnGUI()

    {
        GUI.Label(new Rect(60, 20, 100, 20), "TO DO LIST:", EditorStyles.boldLabel);

        if (GameManager.CurrentDay == 0)
        {
            if (GameManager.PlayerShaved)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Shave beard", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Shave beard", EditorStyles.foldout);
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.foldout);
            }

        }
        else if (GameManager.CurrentDay == 1)
        {
           
            if (GameManager.ComputerActionDone)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Order equipment", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Order equipment", EditorStyles.foldout);
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.foldout);
            }
        }
        else if (GameManager.CurrentDay == 2)
        {
           
            if (GameManager.LaundryDone)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Clean dirty clothing", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Clean dirty clothing", EditorStyles.foldout);
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.foldout);
            }
        }
        else if (GameManager.CurrentDay == 3)
        {
           
            if (GameManager.TrashThrownOut && GameManager.SofaCleaned)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Clean up the house", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Clean up the house", EditorStyles.foldout);
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.foldout);
            }
        }
        else if (GameManager.CurrentDay == 4)
        {
         
            if (GameManager.WorkedOut)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Exercise", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Exercise", EditorStyles.foldout);
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.foldout);
            }
        }
        else if (GameManager.CurrentDay == 5)
        {
            
            if (GameManager.WorkedOut)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Exercise twice", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Exercise twice", EditorStyles.foldout);
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.foldout);
            }
        }
        else if (GameManager.CurrentDay == 6)
        {
            
            if (GameManager.ComputerActionDone)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Order new clothes", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Order new clothes", EditorStyles.foldout);
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.foldout);
            }

            if (GameManager.WorkedOut)
            {
                GUI.Label(new Rect(60, 80, 100, 20), "Exercise", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 80, 100, 20), "Exercise", EditorStyles.foldout);
            }
        }
        else if (GameManager.CurrentDay == 7)
        {
           
            if (GameManager.WearingNewClothes)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Try out new clothes", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Try out new clothes", EditorStyles.foldout);
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.centeredGreyMiniLabel);
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal", EditorStyles.foldout);
            }
        }

    }
}
