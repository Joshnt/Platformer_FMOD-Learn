using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class DistanceToExit : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Victory;
    void Start()
    {
        StartCoroutine(SlowUpdate());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SlowUpdate()
    {
        while (true)
        {
            float distance = Vector2.Distance(gameObject.transform.position, Victory.position); //150 ca max
            RuntimeManager.StudioSystem.setParameterByName("Entfernung zu Ziel", Mathf.Clamp(distance/150, 0f, 1f));
            yield return new WaitForSeconds(0.2f);
        }
    }
}
