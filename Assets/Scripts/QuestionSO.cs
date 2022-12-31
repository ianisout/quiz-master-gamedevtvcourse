using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]

public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    // can also be initialized with values:
    // int[] oddNumbers = new int[5]
    // can also be initialized with values with {}:
    // int[] oddNumbers = {1, 3, 5, 7}

    // STRING instead of VOID because VOID returns NOTHING
    public string GetQuestion()
    {
        return question;
    }
    
    public int GetcorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }
}

/*
    public class Test
    {
        QuestionSO questionSO;

        void TestGetter()
        {
            // returning the value from the string question above
            string questionText = questionSO.GetQuestion();
        }
    }
*/