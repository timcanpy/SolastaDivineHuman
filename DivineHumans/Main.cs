using System;
using UnityModManagerNet;
using HarmonyLib;
using System.Reflection;
using SolastaModApi;
using SolastaDivineHumans;

namespace DivineHumans
{
    public class Main
    {
        [System.Diagnostics.Conditional("DEBUG")]
        public static void Log(string msg)
        {
            if (logger != null) logger.Log(msg);
        }
        public static void Error(Exception ex)
        {
            if (logger != null) logger.Error(ex.ToString());
        }
        public static void Error(string msg)
        {
            if (logger != null) logger.Error(msg);
        }

        public static UnityModManager.ModEntry.ModLogger logger;
        public static bool enabled;

        static bool Load(UnityModManager.ModEntry modEntry)
        {
            try
            {
                logger = modEntry.Logger;
                var harmony = new Harmony(modEntry.Info.Id);
                harmony.PatchAll(Assembly.GetExecutingAssembly());
            }
            catch (Exception ex)
            {
                Error(ex);
                throw ex;
            }
            return true;
        }

        //[HarmonyPatch(typeof(MainMenuScreen), "RuntimeLoaded")]
        //static class MainMenuScreen_RuntimeLoaded_Patch
        [HarmonyPatch(typeof(GameManager), "BindPostDatabase")]
        internal static class GameManager_BindPostDatabase_Patch
        {
            static void Postfix()
            {
                try
                {
                    var clericList = DatabaseRepository.GetDatabase<SpellListDefinition>().GetElement("SpellListCleric");
                    var definition = new DivineHumanFeatureDefinitionCastSpellBuilder(
                            DatabaseHelper.FeatureDefinitionCastSpells.CastSpellElfHigh, // clone original
                            clericList,
                            "DivineHumanSpells", // new name
                            "4b61816bfbd04601b07ddba281ec7d5c") // new guid
                        .AddToDB(); // add to database

                    // assign
                    DatabaseHelper.CharacterRaceDefinitions.Human.FeatureUnlocks.Add(new FeatureUnlockByLevel(definition, 1));
                }

                catch (Exception ex)
                {
                    Error(ex);
                    throw ex;
                }
            }
        }
    }
}

