using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_495 : SimTemplate //* 刃缚精锐 Glaivebound Adept
	{
		//<b>Battlecry:</b> If your hero attacked this turn,deal 4 damage.
		//<b>战吼：</b>在本回合中，如果你的英雄进行过攻击，则造成4点伤害。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{//注意CardDef中添加,22,可以不选中目标
            if(p.ownHero.numAttacksThisTurn >= 1){
            int dmg = 4;
            p.minionGetDamageOrHeal(target, dmg);
		    }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
            };
        }
	}
}
