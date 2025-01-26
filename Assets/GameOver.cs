using UnityEngine;

public class GameOver : MonoBehaviour
{

    public MovePerson Person;
    public LineScript LineScript;
    public LogicScript LogicScript;
    public void endScreen(){
        gameObject.SetActive(true);
    }

    public void reset() {
        gameObject.SetActive(false);
        Person.gameObject.transform.position = new Vector3(7, -1, 0);
        LineScript.gameEnded = false;
        LogicScript.Start();
    }
}
