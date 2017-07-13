using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStabiling : MonoBehaviour
{
    public float StabilingCoef;

    private float _startFieldOfView;
    private float _lastFieldOfView;
    private float _lastCoef;
    private Camera _camera;

	private void Start ()
	{
	    _camera = GetComponent<Camera>();
	    _startFieldOfView = _camera.fieldOfView;
	    _lastFieldOfView = _startFieldOfView;
	}
	
    private void Update()
    {
        var aspect = (float) Screen.width / Screen.height;
        var newFieldOfView = aspect / StabilingCoef;
        _camera.fieldOfView = newFieldOfView;
    }
}
