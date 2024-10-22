using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [구현사항 1] 정적 필드 정의 (완료)
    private static QuestManager instance;

    // [구현사항 2] 정적 프로퍼티 정의
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

    // [구현사항 3] 인스턴스 검사 로직
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
