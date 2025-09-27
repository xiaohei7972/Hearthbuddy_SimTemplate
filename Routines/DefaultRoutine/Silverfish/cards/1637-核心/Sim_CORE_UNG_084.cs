using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：3 生命值：4
	//Fire Plume Phoenix
	//火羽凤凰
	//<b>Battlecry:</b> Deal 3 damage.
	//<b>战吼：</b>造成3点伤害。
	class Sim_CORE_UNG_084 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
                p.minionGetDamageOrHeal(target, 3);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                // new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
		
	}
}
