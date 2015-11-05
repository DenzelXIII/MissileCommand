using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bases;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "megabomb")
        {
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
            Application.LoadLevel("GameOver");
        }
    }
}
