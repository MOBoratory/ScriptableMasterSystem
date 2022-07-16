using UnityEngine;

namespace MOB.ScriptableMasterSystem.Samples
{
    /// <summary>
    /// 動物マスター
    /// </summary>
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
