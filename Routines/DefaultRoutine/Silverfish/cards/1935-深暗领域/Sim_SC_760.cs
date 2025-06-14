using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：3
	//Resonance Coil
	//谐振盘
	//Deal $5 damage to a minion. Get a random Protoss spell.
	//对一个随从造成$5点伤害。随机获取一张星灵法术牌。
	class Sim_SC_760 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			p.minionGetDamageOrHeal(target, 5);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
        }

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从
			};

		}
		
	}
}
