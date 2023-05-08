using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnswerChecker : MonoBehaviour
{
    public string correctAnswer = "5"; // replace with the correct answer

    private TMP_InputField inputField;

    private void Awake()
    {
        inputField = GetComponent<TMP_InputField>();
        inputField.onEndEdit.AddListener(CheckAnswer);
    }

    private void CheckAnswer(string answer)
    {
        if (answer == correctAnswer)
        {
            Debug.Log("Correct!");
            // perform some action to indicate success
        }
        else
        {
            Debug.Log("Incorrect!");
            // perform some action to indicate failure
        }

        inputField.text = ""; // clear the input field
    }
}