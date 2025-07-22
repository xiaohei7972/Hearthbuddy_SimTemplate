using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：0
	//Show of Force
	//力量展现
	//Reduce the Costof all minions in your hand by (2).
	//使你手牌中的所有随从牌的法力值消耗减少（2）点。
	class Sim_TTN_862t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.owncards.ForEach(card =>
            {
                if (card.card.type == CardDB.cardtype.MOB)
                {
                    card.manacost -= 2;
                }
            });
        }
    }
}
