using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS3_031 : SimTemplate //* 生命的缚誓者阿莱克丝塔萨 Alexstrasza the Life-Binder
	{
        //[x]<b>Battlecry</b>: Choose acharacter. If it's friendly,restore 8 Health. If it's an___enemy, deal 8 damage.
        //<b>战吼：</b>选择一个角色。如果是友方角色，为其恢复8点生命值；如果是敌方角色，对其造成8点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if(target != null)
            {
                p.minionGetDamageOrHeal(target, 8 * (own.own == target.own ? -1 : 1));
            }
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}
