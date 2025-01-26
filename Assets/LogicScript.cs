using UnityEngine;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public DollScript doll;
    public QuestionScreen QuestionScreen;

    public LineScript LineScript;
    public void Start()
    {
        doll.Flip(true);
        //LineScript.OnTriggerEnter2D(MovePerson.Person);
        if(LineScript.gameEnded == false){
            QuestionScreen.PopUp(); 
        }
    }


}
