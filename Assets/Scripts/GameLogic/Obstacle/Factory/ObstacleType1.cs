using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObstacleType1 : Obstacle
{
    public EndLocationEvent tileEndSignal;
   /* void OnEnable()
    {
        GameObject[] emitters = GameObject.FindGameObjectsWithTag("TileEnd");
        //����� ���������� ������� ������������� ����� ������� � �������� z ������ ��� � ���������� obstacle
        emitters = emitters.Where(o => o.transform.position.z > transform.position.z).OrderBy(o => o.transform.position.z).ToArray();
        GameObject closestObject = emitters[0];
        if (closestObject != null)
        {
            tileEndSignal = closestObject.GetComponent<EndLocationEvent>();
            tileEndSignal.tileEndSignal += Destroy;
        }
    }*/
    private void Start()
    {
        //tileEndSignal.tileEndSignal += Destroy;
        playerObject = GameObject.FindWithTag("Player");
    }
    public override void Activate()
    {

    }
    public override void Destroy()
    {
            gameObject.SetActive(false);
    }
}