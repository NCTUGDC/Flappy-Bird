using UnityEngine;
using System.Collections;

public class PairPillarManager : MonoBehaviour
{
    [SerializeField]
    PairPillarController pairPillarControllerPrefab;
    public float defaultPairPillarVelocity = 5;
    public float generatePairPillarCycleTime = 2;

    private float countdownTimer;

    void Start ()
    {
        GenerateNewPairPillar(0);
        countdownTimer = generatePairPillarCycleTime;
    }
	
	void Update ()
    {
        countdownTimer -= Time.deltaTime;
        if(countdownTimer <= 0)
        {
            GenerateNewPairPillar(Random.Range(-3, 3));
            countdownTimer = generatePairPillarCycleTime;
        }
    }

    void GenerateNewPairPillar(float verticalOffset)
    {
        PairPillarController pairPillarController = Instantiate(pairPillarControllerPrefab);
        pairPillarController.Velocity = defaultPairPillarVelocity;
        pairPillarController.transform.position = new Vector3(12, 0) + Vector3.up * verticalOffset;
    }
}
