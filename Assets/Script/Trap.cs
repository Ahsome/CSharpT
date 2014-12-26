using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour
    {
    public float delayTime = 3f;
    public float offsetTime;

    // Use this for initialization
    void Start()
        {
        StartCoroutine(Go());
        }

    IEnumerator Go()
        {
        yield return new WaitForSeconds(offsetTime);
        while (true)
            {
            animation.Play();
            yield return new WaitForSeconds(delayTime);
            }
        }
    }
