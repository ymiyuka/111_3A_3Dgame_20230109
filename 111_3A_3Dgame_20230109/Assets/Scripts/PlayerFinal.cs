using UnityEngine;

namespace yo
{
    /// <summary>
    /// 玩家結束
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        private string nameTarget = "終點";

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                FinalManager.instance.GameOver("遊戲結束!");
            }
        }
    }
}

