using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private int i;

    public LifeCycle()
    {
        i = 33;
    }
	void Awake ()
	{
		Debug.Log("Awake(): " + gameObject.name);
	}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start()" + gameObject.name);
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate(): " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update()");
    }
    void LateUpdate()
    {
        Debug.Log("LateUpdate(): " + gameObject.name);
    }
}
