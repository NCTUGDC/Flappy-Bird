using UnityEngine;
using UnityEngine.SceneManagement;

public class PillarController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scene");
        }
    }
}
