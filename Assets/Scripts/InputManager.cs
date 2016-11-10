using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private BirdController birdController;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //0 left 1 right 2 middle
        {
            birdController.Fly();
        }
    }
}
