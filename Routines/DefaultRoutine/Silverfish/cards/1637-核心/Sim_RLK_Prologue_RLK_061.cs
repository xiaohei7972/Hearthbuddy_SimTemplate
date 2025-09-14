using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：2 攻击力：2 生命值：3
	//Battlefield Necromancer
	//战场通灵师
	//[x]At the end of your turn,raise a <b>Corpse</b> as a 1/2__Risen Footman with <b>Taunt</b>.__
	//在你的回合结束时，将一份<b>残骸</b>复活为1/2并具有<b>嘲讽</b>的复活的步兵。
	class Sim_RLK_Prologue_RLK_061 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.RLK_Prologue_RLK_061t);
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (p.getCorpseCount() >= 1)
			{
				p.corpseConsumption(1);
				p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
			};
        }
		
	}
}
