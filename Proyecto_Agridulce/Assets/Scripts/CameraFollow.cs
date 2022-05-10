using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform _player;
    float _differentialY;

    float _distanceOffsetFromPlayer;

    private void Start()
    {
        _distanceOffsetFromPlayer = this.transform.position.z;
    }

    private void Update()
    {
        _differentialY = this.transform.position.y - _player.transform.position.y;
    }

    private void LateUpdate()
    {
        this.transform.position = _player.transform.position + new Vector3(0, _differentialY, _distanceOffsetFromPlayer);
    }
}
