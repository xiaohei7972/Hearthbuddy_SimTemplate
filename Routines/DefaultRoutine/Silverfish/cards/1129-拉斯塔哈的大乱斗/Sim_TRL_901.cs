using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_901 : SimTemplate //* 山猫之灵 Spirit of the Lynx
//[x]<b>Stealth</b> for 1 turn.Whenever you summon a Beast, give it +1/+1.
//<b>潜行</b>一回合。每当你召唤一个野兽时，使其获得+1/+1。 
	{


        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.own == summonedMinion.own && (TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.PET)
            {
                p.minionGetBuffed(summonedMinion, 1, 1); 
            }
        }

	}
}