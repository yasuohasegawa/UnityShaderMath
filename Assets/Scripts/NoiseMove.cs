using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMove : MonoBehaviour
{
    public GameObject m_Prefab;

    private List<GameObject> m_List = new List<GameObject>();
    private float m_Time = 0f;

    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 0; i<25; i++)
        {
            m_List.Add(Instantiate(m_Prefab) as GameObject);
            m_List[i].transform.position = new Vector3(Random.Range(-1f,1f), Random.Range(-1f, 1f), 0.0f);
        }
        m_Prefab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        m_Time += Time.deltaTime;
        int ind = 0;

        for (float y = 2f; y <= 7f; y++)
        {
            for (float x = 2f; x <= 7f; x++)
            {
                if(ind< m_List.Count)
                {
                    Vector2 n = ShaderMath.N22(new Vector2(x, y)) * 2f;
                    Vector2 p = new Vector2(Mathf.Sin(n.x * m_Time), Mathf.Sin(n.y * m_Time));

                    GameObject go = m_List[ind];
                    Vector3 pos = go.transform.position;
                    pos.x = p.x;
                    pos.y = p.y;
                    go.transform.position = pos;
                }
                ind++;
            }
        }

    }
}