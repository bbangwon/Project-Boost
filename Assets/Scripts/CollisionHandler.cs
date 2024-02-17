using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("You finished the level");
                break;
            case "Fuel":
                Debug.Log("You got fuel");
                break;
            default:
                Debug.Log("You died");
                break;
        }
    }

}
