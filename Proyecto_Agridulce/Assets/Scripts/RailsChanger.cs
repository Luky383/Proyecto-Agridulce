using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailsChanger : SwipeVTwo
{
    [SerializeField] GameObject[] rails = new GameObject[0];

    int index = 1;

    public void ChangeRail(int dir)
    {
        index = Mathf.Clamp(index + dir, 0, rails.Length - 1);

        /*Vector3 railXPosition = new Vector3(rails[index].transform.position.x, transform.position.y,transform.position.z);
        transform.position = railXPosition;*/
        //Debug.Log("Muevo");
        transform.position = new Vector3 (rails[index].transform.position.x,transform.position.y,transform.position.z);

    }

    protected override void GetSwipeDir(Vector3 dir)
    {
        int dirNumeric = 0;
        if (dir.x > 0)
        {
            dirNumeric = 1;
        }
        else if (dir.x < 0)
        {
            dirNumeric = -1;
        }
        ChangeRail(dirNumeric);
    }


}
