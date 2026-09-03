using UnityEngine;

public class Target : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Something hit the target: " + collision.gameObject.name);

        if (collision.gameObject.GetComponent<BallPrefab>() != null)
        {
            Debug.Log("It was a ball! Adding point.");
            ScoreManager.Instance.AddPoint();
            Destroy(collision.gameObject);
        }
    }
}