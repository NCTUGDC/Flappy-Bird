using UnityEngine;

public class PairPillarController : MonoBehaviour
{
    public float Velocity { get; set; }

	void Update ()
    {
        transform.position += Vector3.left * Velocity * Time.deltaTime;

        if (transform.position.x <= -15)
        {
            Destroy(this.gameObject);
        }
	}
}
