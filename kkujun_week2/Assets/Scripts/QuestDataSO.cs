using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class QuestDataSO : ScriptableObject
{
    public string QuestName;
    public int QuestRequiredLevel;
    public int QuestNPC;
    public List<QuestDataSO> QuestPrerequisites;
}

[CreateAssetMenu]
public class MonsterQuestDataSO : QuestDataSO
{
    public string QuestDetail;
}

[CreateAssetMenu]
public class EncounterQuestDataSO : QuestDataSO
{
    public string QuestDetail;
}