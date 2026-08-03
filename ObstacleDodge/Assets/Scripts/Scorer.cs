using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log($"You've bumped into an object {hits} times.");
    }
}
