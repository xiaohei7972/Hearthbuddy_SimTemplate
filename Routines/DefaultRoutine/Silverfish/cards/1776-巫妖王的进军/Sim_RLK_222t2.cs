using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：8 攻击力：8 生命值：8
	//Astalor, the Flamebringer
	//火焰使者阿斯塔洛
	//[x]<b>Battlecry:</b> Deal 7 damagerandomly split between allenemies. <b>Manathirst (10):</b>Deal 14 instead.
	//<b>战吼：</b>造成7点伤害，随机分配到所有敌人身上。<b>法力渴求（10）：</b>改为造成14点。
	class Sim_RLK_222t2 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int damage = 7;
			if (p.ownMaxMana >= own.handcard.card.Manathirst)
				damage = 14;
			p.allCharsOfASideGetRandomDamage(!own.own, damage);
        }

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
        {
            {
                if (target != null)
                    p.minionGetDamageOrHeal(target, 2);
            }
        }
		
	}
}
