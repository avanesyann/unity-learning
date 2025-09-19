using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumps = 0;
    void OnCollisionEnter(Collision collision)
    {
        bumps++;
        Debug.Log($"You've bumped into a thing {bumps} times.");
    }
}
