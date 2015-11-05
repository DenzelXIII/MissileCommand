using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class ExplosionManager : MonoBehaviour
{

    private IEnumerator KillOnAnimationEnd()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(this.gameObject);
    }

    void Update()
    {
        StartCoroutine(KillOnAnimationEnd());
    }
}
