using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：2
	//Gyreworm
	//旋岩虫
	//<b>Battlecry:</b> If you played an Elemental last turn, deal 3_damage.
	//<b>战吼：</b>如果你在上个回合使用过元素牌，则造成3点伤害。
	class Sim_DMF_062 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
                p.minionGetDamageOrHeal(target, 3);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN),
                // new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
		
	}
}
