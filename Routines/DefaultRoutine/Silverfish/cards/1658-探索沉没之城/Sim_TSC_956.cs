using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：3
	//Dragged Below
	//拖入深渊
	//[x]Deal $4 damageto a minion.Give your opponentan Abyssal Curse.
	//对一个随从造成$4点伤害。使你的对手获得一张深渊诅咒。
	class Sim_TSC_956 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
				p.minionGetDamageOrHeal(target, damage);
				p.drawACard(CardDB.cardIDEnum.TSC_955t, !ownplay, true);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
			};
        }
		
	}
}
