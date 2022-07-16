using UnityEngine;

namespace MOB.ScriptableMasterSystem.Samples
{
    /// <summary>
    /// 動物マスター
    /// </summary>
    [CreateAssetMenu(order = 1, fileName = "AnimalMaster", menuName = "MOB/ScriptableMasterSystem/Samples/AnimalMaster")]
    public sealed class AnimalMaster : MasterBase
    {
        [SerializeField] private string _animalName;
        [SerializeField] private string _bark;

        /// <summary>動物の名称</summary>
        public string AnimalName => _animalName;
        /// <summary>鳴き声</summary>
        public string Bark => _bark;
    }
}
