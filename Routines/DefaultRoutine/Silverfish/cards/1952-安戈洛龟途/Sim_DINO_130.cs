using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：2 攻击力：0 生命值：2
	//Longneck Egg
	//长颈龙蛋
	//<b>Deathrattle:</b> Summon a 1/2 Beast. Give your minions +1/+1.
	//<b>亡语：</b>召唤一只1/2的野兽。使你的随从获得+1/+1。
	class Sim_DINO_130 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DINO_130t);
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
			p.allMinionOfASideGetBuffed(m.own, 1, 1);
        }
		
	}
}
