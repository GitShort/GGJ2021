using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TodoList : MonoBehaviour
{
    private void OnGUI()

    {
        GUI.Label(new Rect(60, 20, 100, 20), "TO DO LIST:");

        if (GameManager.CurrentDay == 0)
        {
            if (GameManager.PlayerShaved)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Shave beard");
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Shave beard");
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }

        }
        else if (GameManager.CurrentDay == 1)
        {
           
            if (GameManager.ComputerActionDone)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Order equipment");
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Order equipment");
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
        }
        else if (GameManager.CurrentDay == 2)
        {
           
            if (GameManager.LaundryDone)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Clean dirty clothing");
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Clean dirty clothing");
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
        }
        else if (GameManager.CurrentDay == 3)
        {
           
            if (GameManager.TrashThrownOut && GameManager.SofaCleaned)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Clean up the house");
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Clean up the house");
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
        }
        else if (GameManager.CurrentDay == 4)
        {
         
            if (GameManager.WorkedOut)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Exercise");
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Exercise");
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
        }
        else if (GameManager.CurrentDay == 5)
        {
            
            if (GameManager.WorkedOut)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Exercise twice");
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Exercise twice");
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
        }
        else if (GameManager.CurrentDay == 6)
        {
            
            if (GameManager.ComputerActionDone)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Order new clothes");
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Order new clothes");
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }

            if (GameManager.WorkedOut)
            {
                GUI.Label(new Rect(60, 80, 100, 20), "Exercise");
            }
            else
            {
                GUI.Label(new Rect(60, 80, 100, 20), "Exercise");
            }
        }
        else if (GameManager.CurrentDay == 7)
        {
           
            if (GameManager.WearingNewClothes)
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Try out new clothes");
            }
            else
            {
                GUI.Label(new Rect(60, 40, 100, 20), "Try out new clothes");
            }

            if (GameManager.AteFood)
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
            else
            {
                GUI.Label(new Rect(60, 60, 100, 20), "Eat healthy meal");
            }
        }

    }
}
