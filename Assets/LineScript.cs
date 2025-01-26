using UnityEngine;

public class LineScript : MonoBehaviour
{

    //public QuestionScreen QuestionScreen;
    public GameOver GameOver;

    public bool gameEnded = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered");
        if(collision.gameObject.tag == "character"){
            //print("ran the collision");
            gameEnded = true;
            GameOver.endScreen();
        }
        
    }
}
