using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailsChanger : SwipeVTwo //Hacer rails changer un constructor de player y que player herede de swipevtwo
{
    [SerializeField] GameObject[] rails = new GameObject[0];

    int index = 1;
    //
    Player pj;
    //
    private void Start()
    {
        //
        pj = gameObject.GetComponentInChildren<Player>();
        //
    }

    public void ChangeRail(int dir)
    {
        index = Mathf.Clamp(index + dir, 0, rails.Length - 1);

        transform.position = new Vector3 (rails[index].transform.position.x,transform.position.y,transform.position.z);
    }

    protected override void GetSwipeDir(Vector3 dir)
    {
        int dirNumeric = 0;
        
        /*if (dir.x > 0)
        {
            dirNumeric = 1;
        }
        else if (dir.x < 0)
        {
            dirNumeric = -1;
        }
        //
        else if(dir.y > 0)
        {
            pj.Jump();
        }*/

        if (Mathf.Abs(dir.x) > Mathf.Abs(dir.y))
        {
            if (dir.x > 0)
            {
                dirNumeric = 1;
            }
            else if (dir.x < 0)
            {
                dirNumeric = -1;
            }
        }
        else
        {
            if (dir.y > 0)
            {
                pj.Jump();
            }
        }

        ChangeRail(dirNumeric);
    }


}
