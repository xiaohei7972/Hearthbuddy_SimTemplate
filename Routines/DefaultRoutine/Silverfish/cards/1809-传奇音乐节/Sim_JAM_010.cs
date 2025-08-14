using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：2 攻击力：0 生命值：4
	//Jukebox Totem
	//点唱机图腾
	//[x]At the end of your turn,summon a 1/1 SilverHand Recruit.
	//在你的回合结束时，召唤一个1/1的白银之手新兵。
	class Sim_JAM_010 : SimTemplate
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
			if (triggerEffectMinion.own == turnEndOfOwner)
			{
				p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
			}
        }
		
	}
}
