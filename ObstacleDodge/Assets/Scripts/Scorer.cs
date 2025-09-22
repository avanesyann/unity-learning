using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumps = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hit")
        {
            return;
        }
        
        bumps++;
        Debug.Log($"You've bumped into a thing {bumps} times.");
    }
}
