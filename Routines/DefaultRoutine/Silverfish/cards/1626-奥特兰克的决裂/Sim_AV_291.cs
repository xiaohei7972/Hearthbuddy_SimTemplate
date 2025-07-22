using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AV_291 : SimTemplate //* 霜刃豹头领 frostsabermatriarch
    {
        //<b>嘲讽</b> 在本局对战中，你每召唤一只野兽，该牌的法力值消耗便减少（1）点。
        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            //p.tempTrigger.ownBeastSummoned
        }
    }
}
