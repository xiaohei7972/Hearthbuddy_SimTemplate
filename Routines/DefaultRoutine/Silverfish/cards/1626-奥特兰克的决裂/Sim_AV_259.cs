using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_259 : SimTemplate //* 冰霜撕咬 frostbite
	{
		//造成$3点伤害。<b>荣誉消灭：</b>你对手的下一个法术法力值消耗增加（2）点。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, dmg);
                if (dmg == target.Hp)
                {
                    p.loatheb = true;
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
