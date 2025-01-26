using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MovePerson : MonoBehaviour
{
    public float stepDistance;
    public QuestionScreen QuestionScreen;
    public LogicScript LogicScript;

    //public Collider2D Person;
    public Rigidbody2D rigidBody;

    [ContextMenu("move person")]
    public void movePerson(bool backOrForward){
        if(backOrForward){
            StartCoroutine(MoveAndStartLogic(true));
        }else{
            StartCoroutine(MoveAndStartLogic(false));

        }
    }
    private IEnumerator MoveAndStartLogic(bool direction)
    {
        if(direction){
            yield return new WaitForSeconds(0.2f);
            StartCoroutine(move());
            yield return new WaitForSeconds(0.1f); // Wait for 0.3 seconds to see the animation
            StartCoroutine(move());

            yield return new WaitForSeconds(0.5f); // Wait for 0.3 seconds to see the animation
            // Call LogicScript.Start() after both moves are complete
            LogicScript.Start();
        }else{
            yield return new WaitForSeconds(0.2f);
            StartCoroutine(moveBack());
            yield return new WaitForSeconds(0.1f); // Wait for 0.3 seconds to see the animation
            StartCoroutine(moveBack());

            yield return new WaitForSeconds(0.5f); // Wait for 0.3 seconds to see the animation
            // Call LogicScript.Start() after both moves are complete
            LogicScript.Start();
        }
    }

    public IEnumerator move()
    {
        rigidBody.linearVelocity = Vector2.left * stepDistance;
        yield return new WaitForSeconds(0.2f);
        rigidBody.linearVelocity = Vector2.zero;
    }

    public IEnumerator moveBack(){
        rigidBody.linearVelocity = Vector2.right * stepDistance;
        yield return new WaitForSeconds(0.2f);
        rigidBody.linearVelocity = Vector2.zero;
    }
}
