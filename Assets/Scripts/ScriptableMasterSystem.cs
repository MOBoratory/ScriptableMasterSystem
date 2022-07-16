using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MOB.HoRogue.Masters
{
    public abstract class MasterBase : ScriptableObject
    {
        private const string MasterRootDirectoryPath = "Masters/";

        private static readonly Dictionary<Type, MasterBase[]> MasterCachesByType = new();

        [SerializeField] private int _id;

        /// <summary>MasterID</summary>
        public int Id => _id;

        public static void CreateCaches<T>()
            where T : MasterBase
        {
            var masterDirectoryPath = $"{MasterRootDirectoryPath}{typeof(T).Name}";

            var masters = Resources.LoadAll<MasterBase>(masterDirectoryPath)
                .Select(x => (T)x)
                .ToArray();
            MasterCachesByType[typeof(T)] = masters;
        }

        /// <summary>
        ///     IDからMasterを取得します
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Masterインスタンス</returns>
        protected static T GetById<T>(int id)
            where T : MasterBase
        {
            // キャッシュがまだ無ければキャッシュ作成
            if (!MasterCachesByType.ContainsKey(typeof(T))) CreateCaches<T>();

            foreach (var master in MasterCachesByType[typeof(T)].Select(x => (T)x))
                if (master.Id == id)
                    return master;

            // not found.
            return default;
        }
    }
}
