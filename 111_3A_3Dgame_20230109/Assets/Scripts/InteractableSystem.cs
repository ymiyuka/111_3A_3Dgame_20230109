using UnityEngine;
using UnityEngine.Events;

namespace yo
{
    /// <summary>
    /// 互動系統
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;
        [SerializeField,Header("對話結束後的事件")]
        private UnityEvent onDialogueFinish;

        private string nameTarget = "PlayerCapsule";
        private DialoguesSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("畫布對話系統").GetComponent<DialoguesSystem>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                print(other.name);
                dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
            }
        }
        /// <summary>
        /// 隱藏物件
        /// </summary>
        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }
    }
}

