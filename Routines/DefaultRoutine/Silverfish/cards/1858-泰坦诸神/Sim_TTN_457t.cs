using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：3 攻击力：3 生命值：3
	//Eulogizer
	//悼词宣诵者
	//<b>Forged</b><b>Battlecry:</b> Gain 3 <b>Corpses</b>. Deal 3 damage.
	//<b>已锻造</b><b>战吼：</b>获得3份<b>残骸</b>。造成3点伤害。
	class Sim_TTN_457t : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDamageOrHeal(target, 3);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
			};
		}

	}
}
