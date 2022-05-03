using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SwipeVTwo : MonoBehaviour
{
    //[SerializeField] GameObject[] rails = new GameObject[0];
    [SerializeField] float clampingMagnitude = 10;
    [SerializeField] float _timerSwipe;
    float _currentTime;
    //int index = 1;
    Vector3 deltaPos;

    private void Start()
    {
        ResetTimerSwipe();
    }

    void Update()
    {
        _currentTime -= Time.deltaTime;
        Debug.Log(_currentTime);

        if (Input.touchCount > 0 && _currentTime < 0)
        {
            Touch touchOne = Input.touches[0];

            if (touchOne.deltaPosition.magnitude < clampingMagnitude) return;

            GetSwipeDir(touchOne.deltaPosition);
            ResetTimerSwipe();       
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)) deltaPos = Input.mousePosition;

        if (Input.GetKey(KeyCode.Mouse0) && _currentTime < 0)
        {
            Vector3 dirMouse = Input.mousePosition - deltaPos;
            deltaPos = Input.mousePosition;
            if (dirMouse.magnitude < clampingMagnitude) return;

            GetSwipeDir(dirMouse);
            ResetTimerSwipe();
        }
    }

    void ResetTimerSwipe()
    {
        _currentTime = _timerSwipe;
    }

    //public void ChangeRail(int dir)
    //{
    //    index = Mathf.Clamp(index + dir, 0, rails.Length - 1);

    //    transform.position = rails[index].transform.position;
    //}

    protected abstract void GetSwipeDir(Vector3 dir);

}
