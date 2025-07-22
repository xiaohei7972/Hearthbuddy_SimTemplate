using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_250 : SimTemplate //* 雪球大战 snowballfight
	{
        //对一个随从造成$1点伤害并使其<b>冻结</b>。如果该随从没有死亡，则对另一个随从重复此效果！
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);

            int minHp = 100000;
            foreach (Minion m in p.ownMinions)
            {
                if (m.Hp < minHp) minHp = m.Hp;
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.Hp < minHp) minHp = m.Hp;
            }

            int dmgdone = (int)Math.Ceiling((double)minHp / (double)dmg) * dmg;
            p.allMinionsGetDamage(dmgdone);
        }
        //抄的弹射之刃 Bouncing Blade ID：GVG_050 代码，但冰冻受到伤害的随从不好写。


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 1),
            };
        }

    }
}
