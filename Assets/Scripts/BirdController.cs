using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D birdRigidbody;
    public float flyingForceScale = 500;

	void Awake ()
    {
        birdRigidbody = GetComponent<Rigidbody2D>();
	}

    public void Fly()
    {
        birdRigidbody.AddForce(flyingForceScale * Vector2.up);
    }
}
