using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RotionScript : MonoBehaviour {
	public Vector3 _v;
	public Text _text;
	//private Gyroscope gyro;
	// Use this for initialization

	void Start () {

		//gyro=Input.gyro;

		//Debug.Log (gyro);
		//Debug.Log (gyro.enabled);

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (gyro.rotationRateUnbiased.x);
		_v=Input.acceleration*Mathf.Rad2Deg;
		if (_v.z > 0) {
			_text.text="뒤";
		} else {
			_text.text="앞";
		}
			
	}
}
