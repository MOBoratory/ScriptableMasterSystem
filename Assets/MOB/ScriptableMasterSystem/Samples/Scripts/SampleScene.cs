using UnityEngine;

namespace Mob.ScriptableMasterSystem.Samples
{
    /// <summary>
    ///     SampleScene
    /// </summary>
    public sealed class SampleScene : MonoBehaviour
    {
        private void Awake()
        {
            var master = AnimalMaster.GetById(1);
            Debug.Log($"id: {master.Id}, name: {master.name}");
        }
    }
}
