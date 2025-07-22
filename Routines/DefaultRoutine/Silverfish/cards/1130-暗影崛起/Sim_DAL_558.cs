using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_558 : SimTemplate //* 大法师瓦格斯 Archmage Vargoth
//[x]At the end of your turn, casta spell you've cast this turn<i>(targets are random)</i>.
//在你的回合结束时，施放你在本回合中施放过的一个法术<i>（目标随机而定）</i>。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_200); 

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int pos = triggerEffectMinion.zonepos;
                p.drawACard(CardDB.cardNameEN.unknown, turnEndOfOwner, true);
            }
        }
	}
}