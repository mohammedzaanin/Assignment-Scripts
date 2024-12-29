using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
public class ScoreCalculationScenario : MonoBehaviour
{
    int playerScore = 100;
    int diviser = 0;
    void Start()
    {
        try
        {
            Debug.Log("Attempting to calculate score multiplier...");
            int totalScore = playerScore / diviser;
        }
        catch(DivideByZeroException)
        {
            Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
        }
        finally
        {
            Debug.Log("Score calculation complete. Cleaning up resources.");
        }
    }

}
}