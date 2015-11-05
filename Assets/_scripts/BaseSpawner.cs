using UnityEngine;
using System.Collections;

public class BaseSpawner : MonoBehaviour
{
    public GameObject basePrefab;
    public Transform[] basePositions;

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < basePositions.Length; i++)
        {
            Instantiate(basePrefab, basePositions[i].position, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (basePositions == null)
        {
            Application.LoadLevel("GameOver");
        }
	}
}
