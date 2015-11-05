using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RocketSpawner : MonoBehaviour
{
    [SerializeField]private GameObject rocket;
    private GameObject[] _rocket;
    private  List<Rocket> r = new List<Rocket>();
    public Transform[] rocketSpawnPoints;
    public int rocketAmount;
    public int maxRockets;
    public float startTimer;
    public float nextWaveTimer;


    void Awake()
    {
       
    }

	// Use this for initialization
	void Start ()
    {
       
        InvokeRepeating("SpawnRockets",startTimer,nextWaveTimer);
	}

    void SpawnRockets()
    {
            for (int i = 0; i < rocketAmount; i++)
            {
                Instantiate(rocket, rocketSpawnPoints[(Random.Range(0, rocketSpawnPoints.Length))].position, Quaternion.identity);
            }
        rocketAmount++;

    }
}
