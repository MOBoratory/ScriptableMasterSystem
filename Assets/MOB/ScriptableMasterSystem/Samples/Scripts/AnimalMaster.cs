using UnityEngine;

namespace Mob.ScriptableMasterSystem.Samples
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

        public static AnimalMaster GetById(int id)
        {
            return GetById<AnimalMaster>(id);
        }
    }
}
