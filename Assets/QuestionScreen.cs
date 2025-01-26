using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;


public class QuestionScreen : MonoBehaviour
{
    public Text QuestionsText;
    public MovePerson MovePerson;
    public DollScript DollScript;
    public LogicScript LogicScript;


     private List<string> bank = new List<string>
    { "Keeping old credit cards open", 
    "Paying off a loan", 

    "Closing old credit cards",

    "Reviewing your credit history for mistakes", 

    "Opening new credit cards frequently",

    "Paying down high balances",

    "Maxing out your card",
    "Missing credit card payments",

    "Paying bills on time",
    
    "Unpaid Medical Bills"
    };

    private int currQ = 0;



    public void PopUp(){
        if(currQ > 9) currQ = 0;
        QuestionsText.text = bank[currQ];
        gameObject.SetActive(true);
    }

    public IEnumerator wait()
    {
        
        yield return new WaitForSeconds(0.2f);
        
    }

    /*public void correctAnswer() {
        QuestionsText.text = "Correct!";
        gameObject.SetActive(false);
        Invoke("TakeDown", 1);
    }

    public void wrongAnswer() {
        QuestionsText.text = "Correct!";
        gameObject.SetActive(false);
        DollScript.Flip(false);
    }*/

    public void checkAnswerHurts(){
        if(currQ ==2 ||currQ == 4 || currQ == 6 || currQ == 7 || currQ == 9) {
            //QuestionsText.text = "Correct!";
            //StartCoroutine(wait());
            gameObject.SetActive(false);
            Invoke("moveForward", 1);
        }
        else {
            //QuestionsText.text = "Incorrect!";
            //StartCoroutine(wait());
            gameObject.SetActive(false);
            Invoke("moveBack", 1);
        }
        
        currQ++;

    }

    public void checkAnswerHelps(){
        if(currQ ==0 || currQ == 1 || currQ == 3 || currQ == 5 || currQ == 8) {
            gameObject.SetActive(false);
            Invoke("moveForward", 1);
        }
        else {
            gameObject.SetActive(false);
            Invoke("moveBack", 1);
        }
        currQ++;
    }

    /*public void stayStill() {
        DollScript.Flip(false);
        LogicScript.Start();
    }*/

    public void moveBack(){
        DollScript.Flip(true);
        MovePerson.movePerson(false);
    }

    public void moveForward(){
        DollScript.Flip(false);
        MovePerson.movePerson(true);
    }


}

/*using System.Collections.Generic;
using System.Linq; // Required for dictionary traversal
using UnityEngine;
using UnityEngine.UI;

public class QuestionScreen : MonoBehaviour
{
    public Text QuestionsText; // Assign this in the Inspector to a UI Text component
    public MovePerson MovePerson; // Reference to MovePerson script
    public DollScript DollScript; // Reference to DollScript script

    private Dictionary<string, int> bank = new Dictionary<string, int>
    {
        { "Keeping old credit cards open", 1 },
        { "Closing old credit cards", 0 },
        { "Opening new credit cards frequently", 0 },
        { "Paying off a loan", 1 },
        { "Missing credit card payments", 0 },
        { "Reviewing your credit history for mistakes", 1 },
        { "Paying down high balances", 1 },
        { "Maxing out your card", 0 },
        { "Paying bills on time", 1 },
        { "Unpaid Medical Bills", 0 }
    };

    private List<KeyValuePair<string, int>> bankList; // Stores the dictionary as a list
    private int i = 0; // Tracks the current question index

    private void Start()
    {
        // Convert dictionary to a list for ordered traversal
        bankList = bank.ToList();
    }

    public void PopUp()
    {
        // Ensure the index is reset after completing all questions
        if (i >= bankList.Count)
        {
            i = 0;
        }

        // Display the current question
        QuestionsText.text = bankList[i].Key;
        gameObject.SetActive(true); // Show the popup
    }

    public void CheckAnswerHurts()
    {
        // Check if the answer "hurts" (value == 0)
        if (bankList[i].Value == 0)
        {
            QuestionsText.text = "Correct!";
        }
        else
        {
            QuestionsText.text = "Incorrect! Next Question";
            DollScript.Flip(false); // Call DollScript logic if incorrect
        }

        // Move to the next question after a short delay
        Invoke(nameof(HidePopupAndNext), 1f);
    }

    public void CheckAnswerHelps()
    {
        // Check if the answer "helps" (value == 1)
        if (bankList[i].Value == 1)
        {
            QuestionsText.text = "Correct!";
        }
        else
        {
            QuestionsText.text = "Incorrect! Next Question";
            DollScript.Flip(false); // Call DollScript logic if incorrect
        }

        // Move to the next question after a short delay
        Invoke(nameof(HidePopupAndNext), 1f);
    }

    private void HidePopupAndNext()
    {
        gameObject.SetActive(false); // Hide the popup
        i++; // Increment the question index
        MovePerson.MovePerson(); // Call MovePerson logic
    }
}*/
