
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace SettlementsSpecialization.Events
{
    public class IncidentWorker_TestIncident : IncidentWorker
    {
        protected override bool CanFireNowSub(IncidentParms parms)
        {
            Map map = (Map)parms.target;
            if (map.mapPawns.ColonistsSpawnedCount < 5)
            {
                Log.Message($"Colonists count: {map.mapPawns.ColonistsSpawnedCount}");
                return false;
            }
            return true;
        }

        protected override bool TryExecuteWorker(IncidentParms parms)
        {
            Map map = (Map)parms.target;
            if (map.mapPawns.ColonistsSpawnedCount < 5)
            {
                Log.Message($"Colonists count: {map.mapPawns.ColonistsSpawnedCount}");
                return false;
            }

            Log.Message("EXECUTE!!!");

            return true;
        }
    }
}
