using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：3 攻击力：3 生命值：3
	//Eulogizer
	//悼词宣诵者
	//[x]<b>Battlecry:</b> Spend 3 <b>Corpses</b>to deal 3 damage.<b>Forge:</b> Gain them instead.
	//<b>战吼：</b>消耗3份<b>残骸</b>，造成3点伤害。<b>锻造：</b>改为获得残骸。
	class Sim_TTN_457 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.getCorpseCount() >= 3)
			{
				p.corpseConsumption(3);
				if (target != null)
				{

					p.minionGetDamageOrHeal(target, 3);
				}
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
			};
		}

	}
}
