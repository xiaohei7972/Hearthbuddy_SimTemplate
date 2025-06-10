using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TSC_654 : SimTemplate //* 水栖形态 Aquatic Form
//探底。如果你在本回合中有足够的法力值使用选中的牌，则抽取这张牌。
//Dredge.If you have the Mana to play the card this turn, draw it.

    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.activate, ownplay, true);
        }
    }
}
