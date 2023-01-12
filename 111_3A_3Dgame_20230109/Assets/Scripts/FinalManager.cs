using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace yo
{
    /// <summary>
    /// 結束管理器
    /// </summary>
    public class FinalManager : MonoBehaviour
    {
        public static FinalManager instance;

        /// <summary>
        /// 結束畫布
        /// </summary>
        private CanvasGroup groupFinal;
        /// <summary>
        /// 結束標題
        /// </summary>
        private TextMeshProUGUI textTitle;

        private void Awake()
        {
            instance = this;

            groupFinal = GameObject.Find("結束畫布").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();

        }

        public void GameOver(string title)
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }

        private IEnumerator FadeIn()
        {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }


        
    }
}

