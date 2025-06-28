using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：3
	//Photosynthesis
	//光合作用
	//Restore #6 Health. Get 3 random Druid spells.
	//恢复#6点生命值。随机获取3张德鲁伊法术牌。
	class Sim_EDR_848 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int heal = (ownplay) ? p.getSpellHeal(6) : p.getEnemySpellHeal(6);
			p.minionGetDamageOrHeal(target, heal);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
        }

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
				// new PlayReq(CardDB.ErrorType2.REQ_HAND_NOT_FULL) // 手牌未满
			};

		}
	}
}
