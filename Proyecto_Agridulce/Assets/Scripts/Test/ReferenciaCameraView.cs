using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenciaCameraView : MonoBehaviour
{
    Camera _camera;

    [SerializeField]
    Transform _player;
    float _differentialY;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    private void Start()
    {
        _differentialY = this.transform.position.y - _player.transform.position.y;
    }

    private void Update()
    {
        this.transform.position = _player.transform.position + new Vector3(0, _differentialY, 0);
    }

    public void SetHabilityView(bool habilityState)
    {
        _camera.LayerCullingToggle("NormalDimension");
        _camera.LayerCullingToggle("ParallelDimension");
        /*if(habilityState == true)
        {
            _camera.LayerCullingHide("BlackPilar");
            _camera.LayerCullingShow("RedPilar");
        }
        else
        {
            _camera.LayerCullingHide("RedPilar");
            _camera.LayerCullingShow("BlackPilar");
        }*/
    }

}
