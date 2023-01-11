using UnityEngine;

namespace yo
{
    /// <summary>
    /// 對話\資料
    /// </summary>
    [CreateAssetMenu(menuName ="yo/Dialogue Data",fileName ="New Dialogue Data")]
    public class DialogueData : ScriptableObject
    {
        [Header("對話者資料")]
        public string dialogueName;
        [Header("對話者內容"),TextArea(2,10)]
        public string[] dialogueContents;
    }
}

