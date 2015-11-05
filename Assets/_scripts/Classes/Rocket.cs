using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour
{
    private GameObject[] _targets;
    public GameObject explosionPrefab;
    public float speed;
    private Vector2 _currentPos;
    private Vector3 _targetPos;
    private Score _score;
    public int scoreWorth;
    [SerializeField]private float minSpeed;
    [SerializeField]
    private float maxSpeed;


    void Awake()
    {
        _score = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<Score>();
    }

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        _targetPos = Pos();
    }

    Vector3 Pos() {
        _targets = GameObject.FindGameObjectsWithTag("Targets");
        Vector3 pos = new Vector3(_targets[Random.Range(0, _targets.Length)].transform.position.x, _targets[Random.Range(0, _targets.Length)].transform.position.y, 0);
        return pos;
    }

    void EnemyFollow()
    {
            transform.position = Vector2.MoveTowards(transform.position, _targetPos, speed * Time.deltaTime);
    }


    // Update is called once per frame
    void Update()
    {
        EnemyFollow();
    }

    public void RocketPowerIncrease(float amount)
    {
        speed += amount;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Explosion")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            _score.ScoreIncrease(20);
            Destroy(this.gameObject);
        }
    }

}
