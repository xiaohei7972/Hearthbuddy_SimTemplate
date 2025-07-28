using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 巫妖王 费用：5
	//Terror's Grave
	//恐怖之墓
	//[x]Deal 4 damage.<b>Deathrattle:</b> ResummonTyrax, Bone Terror.
	//造成4点伤害。<b>亡语：</b>再次召唤泰拉克斯，魔骸暴龙。
	class Sim_TLC_433t2 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_433t);
          public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            if (triggerMinion.handcard.card.CooldownTurn == 0)
            {
                if (target != null)
                {
                    // 对目标随从造成1点伤害
                    p.minionGetDamageOrHeal(target, 4);
                }
            }
        }

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
		}

        public override PlayReq[] GetUseAbilityReqs()
        {
            return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方

			};
        }
	}
}
