using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：0
	//Heart of Flame
	//烈焰之心
	//Gain +5 Health.Give your hero 5 Armor.
	//获得+5生命值。使你的英雄获得5点护甲值。
	class Sim_TTN_415t3 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            var targetMinions = p.ownMinions.Where(m => m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_415).ToList();
            targetMinions.ForEach(m =>
            {
                m.Hp += 5;
            });
            p.ownHero.armor += 5; // 增加护甲值
        }

    }
}
