using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_009 : SimTemplate //* 黑曜石毁灭者 Obsidian Destroyer
//At the end of your turn, summon a 1/1 Scarab with <b>Taunt</b>.
//在你的回合结束时，召唤一只1/1并具有<b>嘲讽</b>的甲虫。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_009t); 

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int place = triggerEffectMinion.zonepos;
                p.callKid(kid, place, triggerEffectMinion.own);
            }
        }
	}
}