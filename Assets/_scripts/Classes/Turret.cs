using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int distance;
    private float _coolDown;

    // Update is called once per frame
    void Update ()
    {
        Timer();
        var pos = Input.mousePosition;
        pos.z = transform.position.z - Camera.main.transform.position.z;
        pos = Camera.main.ScreenToWorldPoint(pos);

        if (Input.GetMouseButtonDown(0) && _coolDown >= 0.5f)
        {
            Instantiate(explosionPrefab,pos,Quaternion.identity);
            _coolDown = 0;
        }
	}

    void Timer()
    {
        _coolDown = _coolDown + Time.deltaTime;
    }
}
