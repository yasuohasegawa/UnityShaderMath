using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Test : MonoBehaviour
{
    public GameObject m_target;
    float m_Time = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ShaderMath.fract(10.12345f));
        Debug.Log(ShaderMath.smoothstep(-1.0f,1.0f,0.5f));
        Debug.Log(ShaderMath.step(3.3f,1.0f));
        Assert.IsTrue((ShaderMath.step(0.2f, 1.0f) == 1f), "should be 1");
        Assert.IsTrue((ShaderMath.step(1.0f, 1.0f) == 1f), "should be 1");
        Assert.IsTrue((ShaderMath.step(1.1f, 1.0f) == 0f), "should be 0");

        Debug.Log(ShaderMath.mix(-0.2f, 0.3f, 0.5f));
        Debug.Log(ShaderMath.mix(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(1f, 1f, 1f), 0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        m_Time += Time.deltaTime;
        AnimationTest();
    }

    private void AnimationTest()
    {
        float t = ShaderMath.mod(m_Time, 5f);
        float sc = 0.0f;
        sc += ShaderEasings.cubicInOut(ShaderMath.scene(t, 1.0f, 0.7f)) * 1.5f;
        sc -= ShaderEasings.cubicInOut(ShaderMath.scene(t, 4.0f, 0.7f)) * 1.5f;

        //Debug.Log(sc);

        Vector3 pos = m_target.transform.position;
        pos.x = sc;
        m_target.transform.position = pos;
    }
}
