using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 /*
  *  单例模式模板
  *  网上抄的，出问题再说
  */
public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    private static object syncRoot = new Object();
    public static T Instance { get
        { if (_instance == null)
            { lock (syncRoot)
                {
                    if (_instance == null)
                    {
                        T[] instances = FindObjectsOfType<T>();
                        if (instances != null)
                        {
                        for (var i = 0; i < instances.Length; i++)
                            {
                                Destroy(instances[i].gameObject);
                            }
                        }
                        GameObject go = new GameObject();
                        go.name = typeof(T).Name;
                        _instance = go.AddComponent<T>();
                        DontDestroyOnLoad(go);
                    }
                }
            } return _instance;
        }
    }

}