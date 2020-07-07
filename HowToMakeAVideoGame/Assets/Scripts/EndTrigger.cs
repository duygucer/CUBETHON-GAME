using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Transform endLevelO;
    void FixedUpdate()
    {
        if (endLevelO.position.z <= 25)
        {
            gameManager.CompleteLevel();
        }
    }


}
