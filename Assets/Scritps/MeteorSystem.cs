using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSystem : MonoBehaviour
{
    public Transform start, end;
    public Transform meteor;
    public float movementSpeed = 10f;

    private float percentage = 0;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 target = Vector3.Lerp(start.position, end.position, percentage);
        meteor.position = Vector3.MoveTowards(meteor.position, target, movementSpeed * Time.deltaTime);
    }

    public void MoveCloser(float byPercentage)
    {
        percentage += byPercentage;
    }
}
