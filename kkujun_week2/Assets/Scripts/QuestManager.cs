using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [�������� 1] ���� �ʵ� ���� (�Ϸ�)
    private static QuestManager instance;

    // [�������� 2] ���� ������Ƽ ����
    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();
            }
            return instance;
        }
        set
        {
            if ( instance == null )
            {
                GameObject instance = new GameObject("QuestManager");
                instance.AddComponent<QuestManager>();
            }            
        }
    }

    // [�������� 3] �ν��Ͻ� �˻� ����
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }       
        else
        {
            Destroy(this.gameObject);
        }        
    }
}
