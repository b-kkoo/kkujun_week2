using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [�������� 1] ���� �ʵ� ����
    private static QuestManager instance;

    // [�������� 2] ���� ������Ƽ ����
    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();
                if (instance == null)
                {
                    GameObject questManager = new GameObject("QuestManager");
                    questManager.AddComponent<QuestManager>();

                    instance = questManager.GetComponent<QuestManager>();
                }
            }
            return instance;
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
            Destroy(gameObject);
        }        
    }
}
