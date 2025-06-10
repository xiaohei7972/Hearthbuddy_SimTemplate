using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：0
	//Tempering
	//升温回火
	//Gain +5 Attack.Give your hero +5 Attack this turn.
	//获得+5攻击力。在本回合中，使你的英雄获得+5攻击力。
	class Sim_TTN_415t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            var targetMinions = p.ownMinions.Where(m => m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_415).ToList();
            targetMinions.ForEach(m =>
            {
                m.Angr += 5;
            });
            p.ownHero.tempAttack += 5; // 增加英雄攻击力
        }

    }
}
