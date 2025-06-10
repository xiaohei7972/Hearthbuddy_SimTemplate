using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：0
	//Titanforge
	//泰坦锻造
	//Gain +2/+2.Draw a weapon.
	//获得+2/+2。抽一张武器牌。
	class Sim_TTN_415t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            var targetMinions = p.ownMinions.Where(m => m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_415).ToList();
            targetMinions.ForEach(m =>
            {
                m.Angr += 2;
                m.Hp += 2;
            });
            p.drawACard(CardDB.cardIDEnum.None, true); // 抽一张武器牌
        }
    }
}
