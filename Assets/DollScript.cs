using UnityEngine;

public class DollScript : MonoBehaviour
{
    public void Flip(bool whichWay){
        if(whichWay == true){
            gameObject.transform.localScale = new Vector3(-5,5,5);
        }else{
            gameObject.transform.localScale = new Vector3(5,5,5);
        }
    }
}
