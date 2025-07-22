using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：0
	//Reinforced
	//增援
	//Draw 2 minions. Set their Attack, Health, and Cost to 2.
	//抽两张随从牌。将其攻击力，生命值和法力值消耗变为2。
	class Sim_TTN_858t1 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, true, true);
            p.drawACard(CardDB.cardIDEnum.None, true, true);
            var buffedCards = p.owncards.Skip(Math.Max(0, p.owncards.Count - 2)).ToList();
            buffedCards.ForEach(handCard =>
            {
                handCard.card.Attack = 2;
                handCard.card.Health = 2;
                handCard.manacost = 2;
            });
        }
    }
}
