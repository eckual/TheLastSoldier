using UnityEngine;
using TMPro;
using NaughtyAttributes;

namespace LevelEditor
{
    public class LevelEditorWaveData : MonoBehaviour
    {
#if UNITY_EDITOR
        [HideInInspector] public int waveIndex;
        [HideInInspector] public bool intervalChangedManualy;
        [HideInInspector] public bool moveSpeedChangedManualy;
        [Foldout("Fixed Variables")] public TextMeshPro waveIndexText;
        [Foldout("Fixed Variables")] public TextMeshPro IntervalText;
        [Foldout("Fixed Variables")] public TextMeshPro moveSpeedText;
        [Foldout("Fixed Variables")] public MeshRenderer planeMesh;
        public float interval;
        public float enemyMoveSpeed;

        [Foldout("Fixed Variables")] public LevelEditorPointsData pointsData;

        [Button]
        public void UpdateIntervalValue()
        {
            if (interval < 0)
            {
                Debug.LogError("Spawn Interwal value must ve positive float value");
                return;
            }

            intervalChangedManualy = true;
            UpdateTexts();
            FindObjectOfType<LevelEditor>().UpdateTotalDuration();
        }

        [Button]
        public void ResetIntervalValue()
        {
            intervalChangedManualy = false;
            FindObjectOfType<LevelEditor>().UpdateAllIntervalValues();
        }

        [Button]
        public void UpdateEnemyMoveSpeed()
        {
            if(enemyMoveSpeed < 0)
            {
                Debug.LogError("Enemy move speed must ve positive float value");
                return;
            }

            moveSpeedChangedManualy = true;
            UpdateTexts();
        }

        [Button]
        public void ResetEnemyMoveSpeed()
        {
            moveSpeedChangedManualy = false;
            FindObjectOfType<LevelEditor>().UpdateAllMoveSpeedValues();
        }

        

        public void UpdateTexts()
        {
            waveIndexText.text = "Wave: " + waveIndex.ToString();
            IntervalText.text = "Interval: " + interval.ToString("F2");
            moveSpeedText.text = "M. Speed: " + enemyMoveSpeed.ToString("F1");
        }
#endif
    }
}